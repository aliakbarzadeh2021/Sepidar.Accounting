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

namespace Sepidar.Api.Controllers.UnuseableItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UnuseableItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UnuseableItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUnuseableItemCommand command)
        {
            command.Validate();

            var UnuseableItems = await _unitOfWork.UnuseableItemRepository.FindAsync(c => c.Id == command.Id);

            if (UnuseableItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUnuseableItem = Mapper.Map(command);
            await _unitOfWork.UnuseableItemRepository.AddAsync(newUnuseableItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUnuseableItemCommand command)
        {

            command.Validate();

            var UnuseableItem = await _unitOfWork.UnuseableItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UnuseableItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UnuseableItem = Mapper.Map(UnuseableItem, command);
            UnuseableItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UnuseableItem = await _unitOfWork.UnuseableItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UnuseableItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UnuseableItem.IsActive = false;
            UnuseableItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UnuseableItems = await _unitOfWork.UnuseableItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UnuseableItemsDto = Mapper.Map(UnuseableItems);

            return OkResult(CustomMessage.DefaultMessage, UnuseableItemsDto.ToPagingAndSorting(query), UnuseableItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UnuseableItem = await _unitOfWork.UnuseableItemRepository.GetByIdAsync(id);

            if (UnuseableItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UnuseableItemDto = Mapper.Map(UnuseableItem);

            return OkResult( CustomMessage.DefaultMessage , UnuseableItemDto);

        }
    }
}
