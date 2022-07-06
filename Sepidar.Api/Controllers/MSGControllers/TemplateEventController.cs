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

namespace Sepidar.Api.Controllers.TemplateEventControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TemplateEventController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TemplateEventController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTemplateEventCommand command)
        {
            command.Validate();

            var TemplateEvents = await _unitOfWork.TemplateEventRepository.FindAsync(c => c.Id == command.Id);

            if (TemplateEvents.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTemplateEvent = Mapper.Map(command);
            await _unitOfWork.TemplateEventRepository.AddAsync(newTemplateEvent);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTemplateEventCommand command)
        {

            command.Validate();

            var TemplateEvent = await _unitOfWork.TemplateEventRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TemplateEvent == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TemplateEvent = Mapper.Map(TemplateEvent, command);
            TemplateEvent.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TemplateEvent = await _unitOfWork.TemplateEventRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TemplateEvent == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TemplateEvent.IsActive = false;
            TemplateEvent.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TemplateEvents = await _unitOfWork.TemplateEventRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TemplateEventsDto = Mapper.Map(TemplateEvents);

            return OkResult(CustomMessage.DefaultMessage, TemplateEventsDto.ToPagingAndSorting(query), TemplateEventsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TemplateEvent = await _unitOfWork.TemplateEventRepository.GetByIdAsync(id);

            if (TemplateEvent is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TemplateEventDto = Mapper.Map(TemplateEvent);

            return OkResult( CustomMessage.DefaultMessage , TemplateEventDto);

        }
    }
}
