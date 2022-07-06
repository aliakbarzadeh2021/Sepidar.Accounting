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

namespace Sepidar.Api.Controllers.DebitCreditNoteControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DebitCreditNoteController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DebitCreditNoteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDebitCreditNoteCommand command)
        {
            command.Validate();

            var DebitCreditNotes = await _unitOfWork.DebitCreditNoteRepository.FindAsync(c => c.Id == command.Id);

            if (DebitCreditNotes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDebitCreditNote = Mapper.Map(command);
            await _unitOfWork.DebitCreditNoteRepository.AddAsync(newDebitCreditNote);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDebitCreditNoteCommand command)
        {

            command.Validate();

            var DebitCreditNote = await _unitOfWork.DebitCreditNoteRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DebitCreditNote == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DebitCreditNote = Mapper.Map(DebitCreditNote, command);
            DebitCreditNote.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DebitCreditNote = await _unitOfWork.DebitCreditNoteRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DebitCreditNote == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DebitCreditNote.IsActive = false;
            DebitCreditNote.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DebitCreditNotes = await _unitOfWork.DebitCreditNoteRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DebitCreditNotesDto = Mapper.Map(DebitCreditNotes);

            return OkResult(CustomMessage.DefaultMessage, DebitCreditNotesDto.ToPagingAndSorting(query), DebitCreditNotesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DebitCreditNote = await _unitOfWork.DebitCreditNoteRepository.GetByIdAsync(id);

            if (DebitCreditNote is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DebitCreditNoteDto = Mapper.Map(DebitCreditNote);

            return OkResult( CustomMessage.DefaultMessage , DebitCreditNoteDto);

        }
    }
}
