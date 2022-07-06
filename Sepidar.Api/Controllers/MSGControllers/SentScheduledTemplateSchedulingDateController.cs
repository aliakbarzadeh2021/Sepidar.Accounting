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

namespace Sepidar.Api.Controllers.SentScheduledTemplateSchedulingDateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SentScheduledTemplateSchedulingDateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SentScheduledTemplateSchedulingDateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSentScheduledTemplateSchedulingDateCommand command)
        {
            command.Validate();

            var SentScheduledTemplateSchedulingDates = await _unitOfWork.SentScheduledTemplateSchedulingDateRepository.FindAsync(c => c.Id == command.Id);

            if (SentScheduledTemplateSchedulingDates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSentScheduledTemplateSchedulingDate = Mapper.Map(command);
            await _unitOfWork.SentScheduledTemplateSchedulingDateRepository.AddAsync(newSentScheduledTemplateSchedulingDate);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSentScheduledTemplateSchedulingDateCommand command)
        {

            command.Validate();

            var SentScheduledTemplateSchedulingDate = await _unitOfWork.SentScheduledTemplateSchedulingDateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SentScheduledTemplateSchedulingDate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SentScheduledTemplateSchedulingDate = Mapper.Map(SentScheduledTemplateSchedulingDate, command);
            SentScheduledTemplateSchedulingDate.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SentScheduledTemplateSchedulingDate = await _unitOfWork.SentScheduledTemplateSchedulingDateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SentScheduledTemplateSchedulingDate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SentScheduledTemplateSchedulingDate.IsActive = false;
            SentScheduledTemplateSchedulingDate.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SentScheduledTemplateSchedulingDates = await _unitOfWork.SentScheduledTemplateSchedulingDateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SentScheduledTemplateSchedulingDatesDto = Mapper.Map(SentScheduledTemplateSchedulingDates);

            return OkResult(CustomMessage.DefaultMessage, SentScheduledTemplateSchedulingDatesDto.ToPagingAndSorting(query), SentScheduledTemplateSchedulingDatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SentScheduledTemplateSchedulingDate = await _unitOfWork.SentScheduledTemplateSchedulingDateRepository.GetByIdAsync(id);

            if (SentScheduledTemplateSchedulingDate is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SentScheduledTemplateSchedulingDateDto = Mapper.Map(SentScheduledTemplateSchedulingDate);

            return OkResult( CustomMessage.DefaultMessage , SentScheduledTemplateSchedulingDateDto);

        }
    }
}
