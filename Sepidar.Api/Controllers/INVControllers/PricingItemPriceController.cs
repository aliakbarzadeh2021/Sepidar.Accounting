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

namespace Sepidar.Api.Controllers.PricingItemPriceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PricingItemPriceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PricingItemPriceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPricingItemPriceCommand command)
        {
            command.Validate();

            var PricingItemPrices = await _unitOfWork.PricingItemPriceRepository.FindAsync(c => c.Id == command.Id);

            if (PricingItemPrices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPricingItemPrice = Mapper.Map(command);
            await _unitOfWork.PricingItemPriceRepository.AddAsync(newPricingItemPrice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPricingItemPriceCommand command)
        {

            command.Validate();

            var PricingItemPrice = await _unitOfWork.PricingItemPriceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PricingItemPrice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PricingItemPrice = Mapper.Map(PricingItemPrice, command);
            PricingItemPrice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PricingItemPrice = await _unitOfWork.PricingItemPriceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PricingItemPrice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PricingItemPrice.IsActive = false;
            PricingItemPrice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PricingItemPrices = await _unitOfWork.PricingItemPriceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PricingItemPricesDto = Mapper.Map(PricingItemPrices);

            return OkResult(CustomMessage.DefaultMessage, PricingItemPricesDto.ToPagingAndSorting(query), PricingItemPricesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PricingItemPrice = await _unitOfWork.PricingItemPriceRepository.GetByIdAsync(id);

            if (PricingItemPrice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PricingItemPriceDto = Mapper.Map(PricingItemPrice);

            return OkResult( CustomMessage.DefaultMessage , PricingItemPriceDto);

        }
    }
}
