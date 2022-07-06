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

namespace Sepidar.Api.Controllers.LeaveControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LeaveController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public LeaveController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddLeaveCommand command)
        {
            command.Validate();

            var Leaves = await _unitOfWork.LeaveRepository.FindAsync(c => c.Id == command.Id);

            if (Leaves.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newLeave = Mapper.Map(command);
            await _unitOfWork.LeaveRepository.AddAsync(newLeave);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditLeaveCommand command)
        {

            command.Validate();

            var Leave = await _unitOfWork.LeaveRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Leave == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Leave = Mapper.Map(Leave, command);
            Leave.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Leave = await _unitOfWork.LeaveRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Leave == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Leave.IsActive = false;
            Leave.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Leaves = await _unitOfWork.LeaveRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var LeavesDto = Mapper.Map(Leaves);

            return OkResult(CustomMessage.DefaultMessage, LeavesDto.ToPagingAndSorting(query), LeavesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Leave = await _unitOfWork.LeaveRepository.GetByIdAsync(id);

            if (Leave is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var LeaveDto = Mapper.Map(Leave);

            return OkResult( CustomMessage.DefaultMessage , LeaveDto);

        }
    }
}
