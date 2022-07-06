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

namespace Sepidar.Api.Controllers.OrderingScheduleControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OrderingScheduleController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderingScheduleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOrderingScheduleCommand command)
        {
            command.Validate();

            var OrderingSchedules = await _unitOfWork.OrderingScheduleRepository.FindAsync(c => c.Id == command.Id);

            if (OrderingSchedules.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOrderingSchedule = Mapper.Map(command);
            await _unitOfWork.OrderingScheduleRepository.AddAsync(newOrderingSchedule);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOrderingScheduleCommand command)
        {

            command.Validate();

            var OrderingSchedule = await _unitOfWork.OrderingScheduleRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OrderingSchedule == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingSchedule = Mapper.Map(OrderingSchedule, command);
            OrderingSchedule.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OrderingSchedule = await _unitOfWork.OrderingScheduleRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OrderingSchedule == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingSchedule.IsActive = false;
            OrderingSchedule.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OrderingSchedules = await _unitOfWork.OrderingScheduleRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OrderingSchedulesDto = Mapper.Map(OrderingSchedules);

            return OkResult(CustomMessage.DefaultMessage, OrderingSchedulesDto.ToPagingAndSorting(query), OrderingSchedulesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OrderingSchedule = await _unitOfWork.OrderingScheduleRepository.GetByIdAsync(id);

            if (OrderingSchedule is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OrderingScheduleDto = Mapper.Map(OrderingSchedule);

            return OkResult( CustomMessage.DefaultMessage , OrderingScheduleDto);

        }
    }
}
