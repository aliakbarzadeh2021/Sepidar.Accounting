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

namespace Sepidar.Api.Controllers.RepairControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class RepairController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RepairController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddRepairCommand command)
        {
            command.Validate();

            var Repairs = await _unitOfWork.RepairRepository.FindAsync(c => c.Id == command.Id);

            if (Repairs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newRepair = Mapper.Map(command);
            await _unitOfWork.RepairRepository.AddAsync(newRepair);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditRepairCommand command)
        {

            command.Validate();

            var Repair = await _unitOfWork.RepairRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Repair == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Repair = Mapper.Map(Repair, command);
            Repair.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Repair = await _unitOfWork.RepairRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Repair == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Repair.IsActive = false;
            Repair.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Repairs = await _unitOfWork.RepairRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var RepairsDto = Mapper.Map(Repairs);

            return OkResult(CustomMessage.DefaultMessage, RepairsDto.ToPagingAndSorting(query), RepairsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Repair = await _unitOfWork.RepairRepository.GetByIdAsync(id);

            if (Repair is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var RepairDto = Mapper.Map(Repair);

            return OkResult( CustomMessage.DefaultMessage , RepairDto);

        }
    }
}
