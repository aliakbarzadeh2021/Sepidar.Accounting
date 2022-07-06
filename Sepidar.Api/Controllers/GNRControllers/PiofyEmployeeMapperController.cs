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

namespace Sepidar.Api.Controllers.PiofyEmployeeMapperControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PiofyEmployeeMapperController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PiofyEmployeeMapperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPiofyEmployeeMapperCommand command)
        {
            command.Validate();

            var PiofyEmployeeMappers = await _unitOfWork.PiofyEmployeeMapperRepository.FindAsync(c => c.Id == command.Id);

            if (PiofyEmployeeMappers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPiofyEmployeeMapper = Mapper.Map(command);
            await _unitOfWork.PiofyEmployeeMapperRepository.AddAsync(newPiofyEmployeeMapper);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPiofyEmployeeMapperCommand command)
        {

            command.Validate();

            var PiofyEmployeeMapper = await _unitOfWork.PiofyEmployeeMapperRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PiofyEmployeeMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PiofyEmployeeMapper = Mapper.Map(PiofyEmployeeMapper, command);
            PiofyEmployeeMapper.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PiofyEmployeeMapper = await _unitOfWork.PiofyEmployeeMapperRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PiofyEmployeeMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PiofyEmployeeMapper.IsActive = false;
            PiofyEmployeeMapper.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PiofyEmployeeMappers = await _unitOfWork.PiofyEmployeeMapperRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PiofyEmployeeMappersDto = Mapper.Map(PiofyEmployeeMappers);

            return OkResult(CustomMessage.DefaultMessage, PiofyEmployeeMappersDto.ToPagingAndSorting(query), PiofyEmployeeMappersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PiofyEmployeeMapper = await _unitOfWork.PiofyEmployeeMapperRepository.GetByIdAsync(id);

            if (PiofyEmployeeMapper is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PiofyEmployeeMapperDto = Mapper.Map(PiofyEmployeeMapper);

            return OkResult( CustomMessage.DefaultMessage , PiofyEmployeeMapperDto);

        }
    }
}
