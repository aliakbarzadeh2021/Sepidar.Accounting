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

namespace Sepidar.Api.Controllers.OpeningOperationItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OpeningOperationItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OpeningOperationItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOpeningOperationItemCommand command)
        {
            command.Validate();

            var OpeningOperationItems = await _unitOfWork.OpeningOperationItemRepository.FindAsync(c => c.Id == command.Id);

            if (OpeningOperationItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOpeningOperationItem = Mapper.Map(command);
            await _unitOfWork.OpeningOperationItemRepository.AddAsync(newOpeningOperationItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOpeningOperationItemCommand command)
        {

            command.Validate();

            var OpeningOperationItem = await _unitOfWork.OpeningOperationItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OpeningOperationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OpeningOperationItem = Mapper.Map(OpeningOperationItem, command);
            OpeningOperationItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OpeningOperationItem = await _unitOfWork.OpeningOperationItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OpeningOperationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OpeningOperationItem.IsActive = false;
            OpeningOperationItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OpeningOperationItems = await _unitOfWork.OpeningOperationItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OpeningOperationItemsDto = Mapper.Map(OpeningOperationItems);

            return OkResult(CustomMessage.DefaultMessage, OpeningOperationItemsDto.ToPagingAndSorting(query), OpeningOperationItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OpeningOperationItem = await _unitOfWork.OpeningOperationItemRepository.GetByIdAsync(id);

            if (OpeningOperationItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OpeningOperationItemDto = Mapper.Map(OpeningOperationItem);

            return OkResult( CustomMessage.DefaultMessage , OpeningOperationItemDto);

        }
    }
}
