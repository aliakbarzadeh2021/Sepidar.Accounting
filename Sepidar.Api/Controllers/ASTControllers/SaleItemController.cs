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

namespace Sepidar.Api.Controllers.SaleItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SaleItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SaleItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSaleItemCommand command)
        {
            command.Validate();

            var SaleItems = await _unitOfWork.SaleItemRepository.FindAsync(c => c.Id == command.Id);

            if (SaleItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSaleItem = Mapper.Map(command);
            await _unitOfWork.SaleItemRepository.AddAsync(newSaleItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSaleItemCommand command)
        {

            command.Validate();

            var SaleItem = await _unitOfWork.SaleItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SaleItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SaleItem = Mapper.Map(SaleItem, command);
            SaleItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SaleItem = await _unitOfWork.SaleItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SaleItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SaleItem.IsActive = false;
            SaleItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SaleItems = await _unitOfWork.SaleItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SaleItemsDto = Mapper.Map(SaleItems);

            return OkResult(CustomMessage.DefaultMessage, SaleItemsDto.ToPagingAndSorting(query), SaleItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SaleItem = await _unitOfWork.SaleItemRepository.GetByIdAsync(id);

            if (SaleItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SaleItemDto = Mapper.Map(SaleItem);

            return OkResult( CustomMessage.DefaultMessage , SaleItemDto);

        }
    }
}
