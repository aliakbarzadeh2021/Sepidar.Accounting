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

namespace Sepidar.Api.Controllers.CostControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CostController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCostCommand command)
        {
            command.Validate();

            var Costs = await _unitOfWork.CostRepository.FindAsync(c => c.Id == command.Id);

            if (Costs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCost = Mapper.Map(command);
            await _unitOfWork.CostRepository.AddAsync(newCost);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCostCommand command)
        {

            command.Validate();

            var Cost = await _unitOfWork.CostRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Cost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Cost = Mapper.Map(Cost, command);
            Cost.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Cost = await _unitOfWork.CostRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Cost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Cost.IsActive = false;
            Cost.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Costs = await _unitOfWork.CostRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CostsDto = Mapper.Map(Costs);

            return OkResult(CustomMessage.DefaultMessage, CostsDto.ToPagingAndSorting(query), CostsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Cost = await _unitOfWork.CostRepository.GetByIdAsync(id);

            if (Cost is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CostDto = Mapper.Map(Cost);

            return OkResult( CustomMessage.DefaultMessage , CostDto);

        }
    }
}
