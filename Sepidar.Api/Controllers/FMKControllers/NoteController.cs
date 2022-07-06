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

namespace Sepidar.Api.Controllers.NoteControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class NoteController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public NoteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddNoteCommand command)
        {
            command.Validate();

            var Notes = await _unitOfWork.NoteRepository.FindAsync(c => c.Id == command.Id);

            if (Notes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newNote = Mapper.Map(command);
            await _unitOfWork.NoteRepository.AddAsync(newNote);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditNoteCommand command)
        {

            command.Validate();

            var Note = await _unitOfWork.NoteRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Note == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Note = Mapper.Map(Note, command);
            Note.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Note = await _unitOfWork.NoteRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Note == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Note.IsActive = false;
            Note.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Notes = await _unitOfWork.NoteRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var NotesDto = Mapper.Map(Notes);

            return OkResult(CustomMessage.DefaultMessage, NotesDto.ToPagingAndSorting(query), NotesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Note = await _unitOfWork.NoteRepository.GetByIdAsync(id);

            if (Note is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var NoteDto = Mapper.Map(Note);

            return OkResult( CustomMessage.DefaultMessage , NoteDto);

        }
    }
}
