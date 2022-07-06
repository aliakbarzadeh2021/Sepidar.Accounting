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

namespace Sepidar.Api.Controllers.ApiLogControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ApiLogController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ApiLogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddApiLogCommand command)
        {
            command.Validate();

            var ApiLogs = await _unitOfWork.ApiLogRepository.FindAsync(c => c.Id == command.Id);

            if (ApiLogs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newApiLog = Mapper.Map(command);
            await _unitOfWork.ApiLogRepository.AddAsync(newApiLog);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditApiLogCommand command)
        {

            command.Validate();

            var ApiLog = await _unitOfWork.ApiLogRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ApiLog == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ApiLog = Mapper.Map(ApiLog, command);
            ApiLog.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ApiLog = await _unitOfWork.ApiLogRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ApiLog == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ApiLog.IsActive = false;
            ApiLog.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ApiLogs = await _unitOfWork.ApiLogRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ApiLogsDto = Mapper.Map(ApiLogs);

            return OkResult(CustomMessage.DefaultMessage, ApiLogsDto.ToPagingAndSorting(query), ApiLogsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ApiLog = await _unitOfWork.ApiLogRepository.GetByIdAsync(id);

            if (ApiLog is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ApiLogDto = Mapper.Map(ApiLog);

            return OkResult( CustomMessage.DefaultMessage , ApiLogDto);

        }
    }
}
