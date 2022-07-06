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

namespace Sepidar.Api.Controllers.CheckDataParityControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CheckDataParityController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CheckDataParityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCheckDataParityCommand command)
        {
            command.Validate();

            var CheckDataParitys = await _unitOfWork.CheckDataParityRepository.FindAsync(c => c.Id == command.Id);

            if (CheckDataParitys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCheckDataParity = Mapper.Map(command);
            await _unitOfWork.CheckDataParityRepository.AddAsync(newCheckDataParity);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCheckDataParityCommand command)
        {

            command.Validate();

            var CheckDataParity = await _unitOfWork.CheckDataParityRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CheckDataParity == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CheckDataParity = Mapper.Map(CheckDataParity, command);
            CheckDataParity.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CheckDataParity = await _unitOfWork.CheckDataParityRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CheckDataParity == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CheckDataParity.IsActive = false;
            CheckDataParity.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CheckDataParitys = await _unitOfWork.CheckDataParityRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CheckDataParitysDto = Mapper.Map(CheckDataParitys);

            return OkResult(CustomMessage.DefaultMessage, CheckDataParitysDto.ToPagingAndSorting(query), CheckDataParitysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CheckDataParity = await _unitOfWork.CheckDataParityRepository.GetByIdAsync(id);

            if (CheckDataParity is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CheckDataParityDto = Mapper.Map(CheckDataParity);

            return OkResult( CustomMessage.DefaultMessage , CheckDataParityDto);

        }
    }
}
