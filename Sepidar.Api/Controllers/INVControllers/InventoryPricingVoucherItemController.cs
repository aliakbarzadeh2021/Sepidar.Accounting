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

namespace Sepidar.Api.Controllers.InventoryPricingVoucherItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryPricingVoucherItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryPricingVoucherItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryPricingVoucherItemCommand command)
        {
            command.Validate();

            var InventoryPricingVoucherItems = await _unitOfWork.InventoryPricingVoucherItemRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryPricingVoucherItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryPricingVoucherItem = Mapper.Map(command);
            await _unitOfWork.InventoryPricingVoucherItemRepository.AddAsync(newInventoryPricingVoucherItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryPricingVoucherItemCommand command)
        {

            command.Validate();

            var InventoryPricingVoucherItem = await _unitOfWork.InventoryPricingVoucherItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryPricingVoucherItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPricingVoucherItem = Mapper.Map(InventoryPricingVoucherItem, command);
            InventoryPricingVoucherItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryPricingVoucherItem = await _unitOfWork.InventoryPricingVoucherItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryPricingVoucherItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPricingVoucherItem.IsActive = false;
            InventoryPricingVoucherItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryPricingVoucherItems = await _unitOfWork.InventoryPricingVoucherItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryPricingVoucherItemsDto = Mapper.Map(InventoryPricingVoucherItems);

            return OkResult(CustomMessage.DefaultMessage, InventoryPricingVoucherItemsDto.ToPagingAndSorting(query), InventoryPricingVoucherItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryPricingVoucherItem = await _unitOfWork.InventoryPricingVoucherItemRepository.GetByIdAsync(id);

            if (InventoryPricingVoucherItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryPricingVoucherItemDto = Mapper.Map(InventoryPricingVoucherItem);

            return OkResult( CustomMessage.DefaultMessage , InventoryPricingVoucherItemDto);

        }
    }
}
