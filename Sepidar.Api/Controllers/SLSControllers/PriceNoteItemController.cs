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

namespace Sepidar.Api.Controllers.PriceNoteItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PriceNoteItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PriceNoteItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPriceNoteItemCommand command)
        {
            command.Validate();

            var PriceNoteItems = await _unitOfWork.PriceNoteItemRepository.FindAsync(c => c.Id == command.Id);

            if (PriceNoteItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPriceNoteItem = Mapper.Map(command);
            await _unitOfWork.PriceNoteItemRepository.AddAsync(newPriceNoteItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPriceNoteItemCommand command)
        {

            command.Validate();

            var PriceNoteItem = await _unitOfWork.PriceNoteItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PriceNoteItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PriceNoteItem = Mapper.Map(PriceNoteItem, command);
            PriceNoteItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PriceNoteItem = await _unitOfWork.PriceNoteItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PriceNoteItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PriceNoteItem.IsActive = false;
            PriceNoteItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PriceNoteItems = await _unitOfWork.PriceNoteItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PriceNoteItemsDto = Mapper.Map(PriceNoteItems);

            return OkResult(CustomMessage.DefaultMessage, PriceNoteItemsDto.ToPagingAndSorting(query), PriceNoteItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PriceNoteItem = await _unitOfWork.PriceNoteItemRepository.GetByIdAsync(id);

            if (PriceNoteItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PriceNoteItemDto = Mapper.Map(PriceNoteItem);

            return OkResult( CustomMessage.DefaultMessage , PriceNoteItemDto);

        }
    }
}
