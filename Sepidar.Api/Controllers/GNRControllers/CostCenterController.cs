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

namespace Sepidar.Api.Controllers.CostCenterControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CostCenterController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CostCenterController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCostCenterCommand command)
        {
            command.Validate();

            var CostCenters = await _unitOfWork.CostCenterRepository.FindAsync(c => c.Id == command.Id);

            if (CostCenters.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCostCenter = Mapper.Map(command);
            await _unitOfWork.CostCenterRepository.AddAsync(newCostCenter);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCostCenterCommand command)
        {

            command.Validate();

            var CostCenter = await _unitOfWork.CostCenterRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CostCenter == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostCenter = Mapper.Map(CostCenter, command);
            CostCenter.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CostCenter = await _unitOfWork.CostCenterRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CostCenter == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostCenter.IsActive = false;
            CostCenter.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CostCenters = await _unitOfWork.CostCenterRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CostCentersDto = Mapper.Map(CostCenters);

            return OkResult(CustomMessage.DefaultMessage, CostCentersDto.ToPagingAndSorting(query), CostCentersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CostCenter = await _unitOfWork.CostCenterRepository.GetByIdAsync(id);

            if (CostCenter is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CostCenterDto = Mapper.Map(CostCenter);

            return OkResult( CustomMessage.DefaultMessage , CostCenterDto);

        }
    }
}
