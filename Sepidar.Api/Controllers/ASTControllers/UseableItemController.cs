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

namespace Sepidar.Api.Controllers.UseableItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UseableItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UseableItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUseableItemCommand command)
        {
            command.Validate();

            var UseableItems = await _unitOfWork.UseableItemRepository.FindAsync(c => c.Id == command.Id);

            if (UseableItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUseableItem = Mapper.Map(command);
            await _unitOfWork.UseableItemRepository.AddAsync(newUseableItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUseableItemCommand command)
        {

            command.Validate();

            var UseableItem = await _unitOfWork.UseableItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UseableItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UseableItem = Mapper.Map(UseableItem, command);
            UseableItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UseableItem = await _unitOfWork.UseableItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UseableItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UseableItem.IsActive = false;
            UseableItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UseableItems = await _unitOfWork.UseableItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UseableItemsDto = Mapper.Map(UseableItems);

            return OkResult(CustomMessage.DefaultMessage, UseableItemsDto.ToPagingAndSorting(query), UseableItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UseableItem = await _unitOfWork.UseableItemRepository.GetByIdAsync(id);

            if (UseableItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UseableItemDto = Mapper.Map(UseableItem);

            return OkResult( CustomMessage.DefaultMessage , UseableItemDto);

        }
    }
}
