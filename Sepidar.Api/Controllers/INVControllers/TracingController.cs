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

namespace Sepidar.Api.Controllers.TracingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TracingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TracingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTracingCommand command)
        {
            command.Validate();

            var Tracings = await _unitOfWork.TracingRepository.FindAsync(c => c.Id == command.Id);

            if (Tracings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTracing = Mapper.Map(command);
            await _unitOfWork.TracingRepository.AddAsync(newTracing);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTracingCommand command)
        {

            command.Validate();

            var Tracing = await _unitOfWork.TracingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Tracing == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Tracing = Mapper.Map(Tracing, command);
            Tracing.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Tracing = await _unitOfWork.TracingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Tracing == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Tracing.IsActive = false;
            Tracing.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Tracings = await _unitOfWork.TracingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TracingsDto = Mapper.Map(Tracings);

            return OkResult(CustomMessage.DefaultMessage, TracingsDto.ToPagingAndSorting(query), TracingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Tracing = await _unitOfWork.TracingRepository.GetByIdAsync(id);

            if (Tracing is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TracingDto = Mapper.Map(Tracing);

            return OkResult( CustomMessage.DefaultMessage , TracingDto);

        }
    }
}
