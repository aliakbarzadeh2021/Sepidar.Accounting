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

namespace Sepidar.Api.Controllers.UnitControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UnitController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UnitController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUnitCommand command)
        {
            command.Validate();

            var Units = await _unitOfWork.UnitRepository.FindAsync(c => c.Id == command.Id);

            if (Units.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUnit = Mapper.Map(command);
            await _unitOfWork.UnitRepository.AddAsync(newUnit);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUnitCommand command)
        {

            command.Validate();

            var Unit = await _unitOfWork.UnitRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Unit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Unit = Mapper.Map(Unit, command);
            Unit.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Unit = await _unitOfWork.UnitRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Unit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Unit.IsActive = false;
            Unit.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Units = await _unitOfWork.UnitRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UnitsDto = Mapper.Map(Units);

            return OkResult(CustomMessage.DefaultMessage, UnitsDto.ToPagingAndSorting(query), UnitsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Unit = await _unitOfWork.UnitRepository.GetByIdAsync(id);

            if (Unit is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UnitDto = Mapper.Map(Unit);

            return OkResult( CustomMessage.DefaultMessage , UnitDto);

        }
    }
}
