using Microsoft.AspNetCore.Mvc;
using Sepidar.api.Base;
using Sepidar.Domain.Entities;
using Sepidar.Repository;
using Sepidar.Message.Base;
using Sepidar.Message.Commands;
using Sepidar.Message.Dtos;
using Sepidar.Message;
using System;
using System.Linq;
using System.Threading.Tasks;
using Sepidar.Infrastructure.Base;

namespace Sepidar.Api.Controllers.SalesLimitItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SalesLimitItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalesLimitItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSalesLimitItemCommand command)
        {
            command.Validate();

            var SalesLimitItems = await _unitOfWork.SalesLimitItemRepository.FindAsync(c => c.Id == command.Id);

            if (SalesLimitItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSalesLimitItem = Mapper.Map(command);
            await _unitOfWork.SalesLimitItemRepository.AddAsync(newSalesLimitItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSalesLimitItemCommand command)
        {

            command.Validate();

            var SalesLimitItem = await _unitOfWork.SalesLimitItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SalesLimitItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SalesLimitItem = Mapper.Map(SalesLimitItem, command);
            SalesLimitItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SalesLimitItem = await _unitOfWork.SalesLimitItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SalesLimitItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SalesLimitItem.IsActive = false;
            SalesLimitItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SalesLimitItems = await _unitOfWork.SalesLimitItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SalesLimitItemsDto = Mapper.Map(SalesLimitItems);

            return OkResult(CustomMessage.DefaultMessage, SalesLimitItemsDto.ToPagingAndSorting(query), SalesLimitItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SalesLimitItem = await _unitOfWork.SalesLimitItemRepository.GetByIdAsync(id);

            if (SalesLimitItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SalesLimitItemDto = Mapper.Map(SalesLimitItem);

            return OkResult( CustomMessage.DefaultMessage , SalesLimitItemDto);

        }
    }
}
