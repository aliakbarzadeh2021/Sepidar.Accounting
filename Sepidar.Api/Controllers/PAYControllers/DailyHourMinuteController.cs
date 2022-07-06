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

namespace Sepidar.Api.Controllers.DailyHourMinuteControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DailyHourMinuteController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DailyHourMinuteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDailyHourMinuteCommand command)
        {
            command.Validate();

            var DailyHourMinutes = await _unitOfWork.DailyHourMinuteRepository.FindAsync(c => c.Id == command.Id);

            if (DailyHourMinutes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDailyHourMinute = Mapper.Map(command);
            await _unitOfWork.DailyHourMinuteRepository.AddAsync(newDailyHourMinute);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDailyHourMinuteCommand command)
        {

            command.Validate();

            var DailyHourMinute = await _unitOfWork.DailyHourMinuteRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DailyHourMinute == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DailyHourMinute = Mapper.Map(DailyHourMinute, command);
            DailyHourMinute.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DailyHourMinute = await _unitOfWork.DailyHourMinuteRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DailyHourMinute == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DailyHourMinute.IsActive = false;
            DailyHourMinute.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DailyHourMinutes = await _unitOfWork.DailyHourMinuteRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DailyHourMinutesDto = Mapper.Map(DailyHourMinutes);

            return OkResult(CustomMessage.DefaultMessage, DailyHourMinutesDto.ToPagingAndSorting(query), DailyHourMinutesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DailyHourMinute = await _unitOfWork.DailyHourMinuteRepository.GetByIdAsync(id);

            if (DailyHourMinute is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DailyHourMinuteDto = Mapper.Map(DailyHourMinute);

            return OkResult( CustomMessage.DefaultMessage , DailyHourMinuteDto);

        }
    }
}
