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

namespace Sepidar.Api.Controllers.SchedulingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SchedulingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SchedulingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSchedulingCommand command)
        {
            command.Validate();

            var Schedulings = await _unitOfWork.SchedulingRepository.FindAsync(c => c.Id == command.Id);

            if (Schedulings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newScheduling = Mapper.Map(command);
            await _unitOfWork.SchedulingRepository.AddAsync(newScheduling);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSchedulingCommand command)
        {

            command.Validate();

            var Scheduling = await _unitOfWork.SchedulingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Scheduling == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Scheduling = Mapper.Map(Scheduling, command);
            Scheduling.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Scheduling = await _unitOfWork.SchedulingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Scheduling == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Scheduling.IsActive = false;
            Scheduling.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Schedulings = await _unitOfWork.SchedulingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SchedulingsDto = Mapper.Map(Schedulings);

            return OkResult(CustomMessage.DefaultMessage, SchedulingsDto.ToPagingAndSorting(query), SchedulingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Scheduling = await _unitOfWork.SchedulingRepository.GetByIdAsync(id);

            if (Scheduling is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SchedulingDto = Mapper.Map(Scheduling);

            return OkResult( CustomMessage.DefaultMessage , SchedulingDto);

        }
    }
}
