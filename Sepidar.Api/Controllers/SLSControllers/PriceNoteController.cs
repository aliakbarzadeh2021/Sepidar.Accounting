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

namespace Sepidar.Api.Controllers.PriceNoteControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PriceNoteController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PriceNoteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPriceNoteCommand command)
        {
            command.Validate();

            var PriceNotes = await _unitOfWork.PriceNoteRepository.FindAsync(c => c.Id == command.Id);

            if (PriceNotes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPriceNote = Mapper.Map(command);
            await _unitOfWork.PriceNoteRepository.AddAsync(newPriceNote);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPriceNoteCommand command)
        {

            command.Validate();

            var PriceNote = await _unitOfWork.PriceNoteRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PriceNote == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PriceNote = Mapper.Map(PriceNote, command);
            PriceNote.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PriceNote = await _unitOfWork.PriceNoteRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PriceNote == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PriceNote.IsActive = false;
            PriceNote.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PriceNotes = await _unitOfWork.PriceNoteRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PriceNotesDto = Mapper.Map(PriceNotes);

            return OkResult(CustomMessage.DefaultMessage, PriceNotesDto.ToPagingAndSorting(query), PriceNotesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PriceNote = await _unitOfWork.PriceNoteRepository.GetByIdAsync(id);

            if (PriceNote is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PriceNoteDto = Mapper.Map(PriceNote);

            return OkResult( CustomMessage.DefaultMessage , PriceNoteDto);

        }
    }
}
