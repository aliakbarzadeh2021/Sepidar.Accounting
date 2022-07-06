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

namespace Sepidar.Api.Controllers.PurchaseCostControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseCostController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PurchaseCostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPurchaseCostCommand command)
        {
            command.Validate();

            var PurchaseCosts = await _unitOfWork.PurchaseCostRepository.FindAsync(c => c.Id == command.Id);

            if (PurchaseCosts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPurchaseCost = Mapper.Map(command);
            await _unitOfWork.PurchaseCostRepository.AddAsync(newPurchaseCost);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPurchaseCostCommand command)
        {

            command.Validate();

            var PurchaseCost = await _unitOfWork.PurchaseCostRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PurchaseCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseCost = Mapper.Map(PurchaseCost, command);
            PurchaseCost.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PurchaseCost = await _unitOfWork.PurchaseCostRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PurchaseCost == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseCost.IsActive = false;
            PurchaseCost.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PurchaseCosts = await _unitOfWork.PurchaseCostRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PurchaseCostsDto = Mapper.Map(PurchaseCosts);

            return OkResult(CustomMessage.DefaultMessage, PurchaseCostsDto.ToPagingAndSorting(query), PurchaseCostsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PurchaseCost = await _unitOfWork.PurchaseCostRepository.GetByIdAsync(id);

            if (PurchaseCost is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PurchaseCostDto = Mapper.Map(PurchaseCost);

            return OkResult( CustomMessage.DefaultMessage , PurchaseCostDto);

        }
    }
}
