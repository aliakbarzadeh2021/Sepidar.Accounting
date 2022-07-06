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

namespace Sepidar.Api.Controllers.PayrollCalendarControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayrollCalendarController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayrollCalendarController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayrollCalendarCommand command)
        {
            command.Validate();

            var PayrollCalendars = await _unitOfWork.PayrollCalendarRepository.FindAsync(c => c.Id == command.Id);

            if (PayrollCalendars.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayrollCalendar = Mapper.Map(command);
            await _unitOfWork.PayrollCalendarRepository.AddAsync(newPayrollCalendar);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayrollCalendarCommand command)
        {

            command.Validate();

            var PayrollCalendar = await _unitOfWork.PayrollCalendarRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayrollCalendar == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayrollCalendar = Mapper.Map(PayrollCalendar, command);
            PayrollCalendar.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayrollCalendar = await _unitOfWork.PayrollCalendarRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayrollCalendar == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayrollCalendar.IsActive = false;
            PayrollCalendar.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayrollCalendars = await _unitOfWork.PayrollCalendarRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayrollCalendarsDto = Mapper.Map(PayrollCalendars);

            return OkResult(CustomMessage.DefaultMessage, PayrollCalendarsDto.ToPagingAndSorting(query), PayrollCalendarsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayrollCalendar = await _unitOfWork.PayrollCalendarRepository.GetByIdAsync(id);

            if (PayrollCalendar is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayrollCalendarDto = Mapper.Map(PayrollCalendar);

            return OkResult( CustomMessage.DefaultMessage , PayrollCalendarDto);

        }
    }
}
