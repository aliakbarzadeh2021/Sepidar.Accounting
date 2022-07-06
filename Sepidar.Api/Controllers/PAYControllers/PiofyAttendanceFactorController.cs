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

namespace Sepidar.Api.Controllers.PiofyAttendanceFactorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PiofyAttendanceFactorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PiofyAttendanceFactorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPiofyAttendanceFactorCommand command)
        {
            command.Validate();

            var PiofyAttendanceFactors = await _unitOfWork.PiofyAttendanceFactorRepository.FindAsync(c => c.Id == command.Id);

            if (PiofyAttendanceFactors.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPiofyAttendanceFactor = Mapper.Map(command);
            await _unitOfWork.PiofyAttendanceFactorRepository.AddAsync(newPiofyAttendanceFactor);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPiofyAttendanceFactorCommand command)
        {

            command.Validate();

            var PiofyAttendanceFactor = await _unitOfWork.PiofyAttendanceFactorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PiofyAttendanceFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PiofyAttendanceFactor = Mapper.Map(PiofyAttendanceFactor, command);
            PiofyAttendanceFactor.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PiofyAttendanceFactor = await _unitOfWork.PiofyAttendanceFactorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PiofyAttendanceFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PiofyAttendanceFactor.IsActive = false;
            PiofyAttendanceFactor.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PiofyAttendanceFactors = await _unitOfWork.PiofyAttendanceFactorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PiofyAttendanceFactorsDto = Mapper.Map(PiofyAttendanceFactors);

            return OkResult(CustomMessage.DefaultMessage, PiofyAttendanceFactorsDto.ToPagingAndSorting(query), PiofyAttendanceFactorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PiofyAttendanceFactor = await _unitOfWork.PiofyAttendanceFactorRepository.GetByIdAsync(id);

            if (PiofyAttendanceFactor is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PiofyAttendanceFactorDto = Mapper.Map(PiofyAttendanceFactor);

            return OkResult( CustomMessage.DefaultMessage , PiofyAttendanceFactorDto);

        }
    }
}
