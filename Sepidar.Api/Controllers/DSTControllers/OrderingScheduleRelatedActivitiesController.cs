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

namespace Sepidar.Api.Controllers.OrderingScheduleRelatedActivitiesControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OrderingScheduleRelatedActivitiesController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderingScheduleRelatedActivitiesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOrderingScheduleRelatedActivitiesCommand command)
        {
            command.Validate();

            var OrderingScheduleRelatedActivitiess = await _unitOfWork.OrderingScheduleRelatedActivitiesRepository.FindAsync(c => c.Id == command.Id);

            if (OrderingScheduleRelatedActivitiess.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOrderingScheduleRelatedActivities = Mapper.Map(command);
            await _unitOfWork.OrderingScheduleRelatedActivitiesRepository.AddAsync(newOrderingScheduleRelatedActivities);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOrderingScheduleRelatedActivitiesCommand command)
        {

            command.Validate();

            var OrderingScheduleRelatedActivities = await _unitOfWork.OrderingScheduleRelatedActivitiesRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OrderingScheduleRelatedActivities == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingScheduleRelatedActivities = Mapper.Map(OrderingScheduleRelatedActivities, command);
            OrderingScheduleRelatedActivities.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OrderingScheduleRelatedActivities = await _unitOfWork.OrderingScheduleRelatedActivitiesRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OrderingScheduleRelatedActivities == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingScheduleRelatedActivities.IsActive = false;
            OrderingScheduleRelatedActivities.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OrderingScheduleRelatedActivitiess = await _unitOfWork.OrderingScheduleRelatedActivitiesRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OrderingScheduleRelatedActivitiessDto = Mapper.Map(OrderingScheduleRelatedActivitiess);

            return OkResult(CustomMessage.DefaultMessage, OrderingScheduleRelatedActivitiessDto.ToPagingAndSorting(query), OrderingScheduleRelatedActivitiessDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OrderingScheduleRelatedActivities = await _unitOfWork.OrderingScheduleRelatedActivitiesRepository.GetByIdAsync(id);

            if (OrderingScheduleRelatedActivities is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OrderingScheduleRelatedActivitiesDto = Mapper.Map(OrderingScheduleRelatedActivities);

            return OkResult( CustomMessage.DefaultMessage , OrderingScheduleRelatedActivitiesDto);

        }
    }
}
