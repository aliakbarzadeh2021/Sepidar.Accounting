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

namespace Sepidar.Api.Controllers.CostPartControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CostPartController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CostPartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCostPartCommand command)
        {
            command.Validate();

            var CostParts = await _unitOfWork.CostPartRepository.FindAsync(c => c.Id == command.Id);

            if (CostParts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCostPart = Mapper.Map(command);
            await _unitOfWork.CostPartRepository.AddAsync(newCostPart);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCostPartCommand command)
        {

            command.Validate();

            var CostPart = await _unitOfWork.CostPartRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CostPart == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostPart = Mapper.Map(CostPart, command);
            CostPart.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CostPart = await _unitOfWork.CostPartRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CostPart == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostPart.IsActive = false;
            CostPart.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CostParts = await _unitOfWork.CostPartRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CostPartsDto = Mapper.Map(CostParts);

            return OkResult(CustomMessage.DefaultMessage, CostPartsDto.ToPagingAndSorting(query), CostPartsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CostPart = await _unitOfWork.CostPartRepository.GetByIdAsync(id);

            if (CostPart is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CostPartDto = Mapper.Map(CostPart);

            return OkResult( CustomMessage.DefaultMessage , CostPartDto);

        }
    }
}
