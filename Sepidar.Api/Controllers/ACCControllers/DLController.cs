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

namespace Sepidar.Api.Controllers.DLControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DLController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DLController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDLCommand command)
        {
            command.Validate();

            var DLs = await _unitOfWork.DLRepository.FindAsync(c => c.Id == command.Id);

            if (DLs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDL = Mapper.Map(command);
            await _unitOfWork.DLRepository.AddAsync(newDL);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDLCommand command)
        {

            command.Validate();

            var DL = await _unitOfWork.DLRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DL = Mapper.Map(DL, command);
            DL.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DL = await _unitOfWork.DLRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DL == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DL.IsActive = false;
            DL.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DLs = await _unitOfWork.DLRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DLsDto = Mapper.Map(DLs);

            return OkResult(CustomMessage.DefaultMessage, DLsDto.ToPagingAndSorting(query), DLsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DL = await _unitOfWork.DLRepository.GetByIdAsync(id);

            if (DL is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DLDto = Mapper.Map(DL);

            return OkResult( CustomMessage.DefaultMessage , DLDto);

        }
    }
}
