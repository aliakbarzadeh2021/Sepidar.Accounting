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

namespace Sepidar.Api.Controllers.OrderingScheduleRecurrenceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OrderingScheduleRecurrenceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderingScheduleRecurrenceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOrderingScheduleRecurrenceCommand command)
        {
            command.Validate();

            var OrderingScheduleRecurrences = await _unitOfWork.OrderingScheduleRecurrenceRepository.FindAsync(c => c.Id == command.Id);

            if (OrderingScheduleRecurrences.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOrderingScheduleRecurrence = Mapper.Map(command);
            await _unitOfWork.OrderingScheduleRecurrenceRepository.AddAsync(newOrderingScheduleRecurrence);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOrderingScheduleRecurrenceCommand command)
        {

            command.Validate();

            var OrderingScheduleRecurrence = await _unitOfWork.OrderingScheduleRecurrenceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OrderingScheduleRecurrence == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingScheduleRecurrence = Mapper.Map(OrderingScheduleRecurrence, command);
            OrderingScheduleRecurrence.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OrderingScheduleRecurrence = await _unitOfWork.OrderingScheduleRecurrenceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OrderingScheduleRecurrence == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingScheduleRecurrence.IsActive = false;
            OrderingScheduleRecurrence.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OrderingScheduleRecurrences = await _unitOfWork.OrderingScheduleRecurrenceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OrderingScheduleRecurrencesDto = Mapper.Map(OrderingScheduleRecurrences);

            return OkResult(CustomMessage.DefaultMessage, OrderingScheduleRecurrencesDto.ToPagingAndSorting(query), OrderingScheduleRecurrencesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OrderingScheduleRecurrence = await _unitOfWork.OrderingScheduleRecurrenceRepository.GetByIdAsync(id);

            if (OrderingScheduleRecurrence is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OrderingScheduleRecurrenceDto = Mapper.Map(OrderingScheduleRecurrence);

            return OkResult( CustomMessage.DefaultMessage , OrderingScheduleRecurrenceDto);

        }
    }
}
