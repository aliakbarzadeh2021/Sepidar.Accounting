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

namespace Sepidar.Api.Controllers.DebitCreditNoteItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DebitCreditNoteItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DebitCreditNoteItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDebitCreditNoteItemCommand command)
        {
            command.Validate();

            var DebitCreditNoteItems = await _unitOfWork.DebitCreditNoteItemRepository.FindAsync(c => c.Id == command.Id);

            if (DebitCreditNoteItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDebitCreditNoteItem = Mapper.Map(command);
            await _unitOfWork.DebitCreditNoteItemRepository.AddAsync(newDebitCreditNoteItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDebitCreditNoteItemCommand command)
        {

            command.Validate();

            var DebitCreditNoteItem = await _unitOfWork.DebitCreditNoteItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DebitCreditNoteItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DebitCreditNoteItem = Mapper.Map(DebitCreditNoteItem, command);
            DebitCreditNoteItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DebitCreditNoteItem = await _unitOfWork.DebitCreditNoteItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DebitCreditNoteItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DebitCreditNoteItem.IsActive = false;
            DebitCreditNoteItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DebitCreditNoteItems = await _unitOfWork.DebitCreditNoteItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DebitCreditNoteItemsDto = Mapper.Map(DebitCreditNoteItems);

            return OkResult(CustomMessage.DefaultMessage, DebitCreditNoteItemsDto.ToPagingAndSorting(query), DebitCreditNoteItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DebitCreditNoteItem = await _unitOfWork.DebitCreditNoteItemRepository.GetByIdAsync(id);

            if (DebitCreditNoteItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DebitCreditNoteItemDto = Mapper.Map(DebitCreditNoteItem);

            return OkResult( CustomMessage.DefaultMessage , DebitCreditNoteItemDto);

        }
    }
}
