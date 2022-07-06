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

namespace Sepidar.Api.Controllers.InventoryPricingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryPricingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryPricingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryPricingCommand command)
        {
            command.Validate();

            var InventoryPricings = await _unitOfWork.InventoryPricingRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryPricings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryPricing = Mapper.Map(command);
            await _unitOfWork.InventoryPricingRepository.AddAsync(newInventoryPricing);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryPricingCommand command)
        {

            command.Validate();

            var InventoryPricing = await _unitOfWork.InventoryPricingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryPricing == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPricing = Mapper.Map(InventoryPricing, command);
            InventoryPricing.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryPricing = await _unitOfWork.InventoryPricingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryPricing == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPricing.IsActive = false;
            InventoryPricing.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryPricings = await _unitOfWork.InventoryPricingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryPricingsDto = Mapper.Map(InventoryPricings);

            return OkResult(CustomMessage.DefaultMessage, InventoryPricingsDto.ToPagingAndSorting(query), InventoryPricingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryPricing = await _unitOfWork.InventoryPricingRepository.GetByIdAsync(id);

            if (InventoryPricing is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryPricingDto = Mapper.Map(InventoryPricing);

            return OkResult( CustomMessage.DefaultMessage , InventoryPricingDto);

        }
    }
}
