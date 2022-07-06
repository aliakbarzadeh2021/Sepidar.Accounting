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

namespace Sepidar.Api.Controllers.InventoryPurchaseInvoiceItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryPurchaseInvoiceItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryPurchaseInvoiceItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryPurchaseInvoiceItemCommand command)
        {
            command.Validate();

            var InventoryPurchaseInvoiceItems = await _unitOfWork.InventoryPurchaseInvoiceItemRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryPurchaseInvoiceItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryPurchaseInvoiceItem = Mapper.Map(command);
            await _unitOfWork.InventoryPurchaseInvoiceItemRepository.AddAsync(newInventoryPurchaseInvoiceItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryPurchaseInvoiceItemCommand command)
        {

            command.Validate();

            var InventoryPurchaseInvoiceItem = await _unitOfWork.InventoryPurchaseInvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryPurchaseInvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPurchaseInvoiceItem = Mapper.Map(InventoryPurchaseInvoiceItem, command);
            InventoryPurchaseInvoiceItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryPurchaseInvoiceItem = await _unitOfWork.InventoryPurchaseInvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryPurchaseInvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPurchaseInvoiceItem.IsActive = false;
            InventoryPurchaseInvoiceItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryPurchaseInvoiceItems = await _unitOfWork.InventoryPurchaseInvoiceItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryPurchaseInvoiceItemsDto = Mapper.Map(InventoryPurchaseInvoiceItems);

            return OkResult(CustomMessage.DefaultMessage, InventoryPurchaseInvoiceItemsDto.ToPagingAndSorting(query), InventoryPurchaseInvoiceItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryPurchaseInvoiceItem = await _unitOfWork.InventoryPurchaseInvoiceItemRepository.GetByIdAsync(id);

            if (InventoryPurchaseInvoiceItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryPurchaseInvoiceItemDto = Mapper.Map(InventoryPurchaseInvoiceItem);

            return OkResult( CustomMessage.DefaultMessage , InventoryPurchaseInvoiceItemDto);

        }
    }
}
