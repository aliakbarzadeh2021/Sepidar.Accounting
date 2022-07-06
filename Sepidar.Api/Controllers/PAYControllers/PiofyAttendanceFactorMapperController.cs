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

namespace Sepidar.Api.Controllers.PiofyAttendanceFactorMapperControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PiofyAttendanceFactorMapperController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PiofyAttendanceFactorMapperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPiofyAttendanceFactorMapperCommand command)
        {
            command.Validate();

            var PiofyAttendanceFactorMappers = await _unitOfWork.PiofyAttendanceFactorMapperRepository.FindAsync(c => c.Id == command.Id);

            if (PiofyAttendanceFactorMappers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPiofyAttendanceFactorMapper = Mapper.Map(command);
            await _unitOfWork.PiofyAttendanceFactorMapperRepository.AddAsync(newPiofyAttendanceFactorMapper);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPiofyAttendanceFactorMapperCommand command)
        {

            command.Validate();

            var PiofyAttendanceFactorMapper = await _unitOfWork.PiofyAttendanceFactorMapperRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PiofyAttendanceFactorMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PiofyAttendanceFactorMapper = Mapper.Map(PiofyAttendanceFactorMapper, command);
            PiofyAttendanceFactorMapper.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PiofyAttendanceFactorMapper = await _unitOfWork.PiofyAttendanceFactorMapperRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PiofyAttendanceFactorMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PiofyAttendanceFactorMapper.IsActive = false;
            PiofyAttendanceFactorMapper.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PiofyAttendanceFactorMappers = await _unitOfWork.PiofyAttendanceFactorMapperRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PiofyAttendanceFactorMappersDto = Mapper.Map(PiofyAttendanceFactorMappers);

            return OkResult(CustomMessage.DefaultMessage, PiofyAttendanceFactorMappersDto.ToPagingAndSorting(query), PiofyAttendanceFactorMappersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PiofyAttendanceFactorMapper = await _unitOfWork.PiofyAttendanceFactorMapperRepository.GetByIdAsync(id);

            if (PiofyAttendanceFactorMapper is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PiofyAttendanceFactorMapperDto = Mapper.Map(PiofyAttendanceFactorMapper);

            return OkResult( CustomMessage.DefaultMessage , PiofyAttendanceFactorMapperDto);

        }
    }
}
