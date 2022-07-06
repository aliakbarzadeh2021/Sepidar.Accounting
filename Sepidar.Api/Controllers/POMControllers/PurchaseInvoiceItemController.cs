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

namespace Sepidar.Api.Controllers.PurchaseInvoiceItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseInvoiceItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PurchaseInvoiceItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPurchaseInvoiceItemCommand command)
        {
            command.Validate();

            var PurchaseInvoiceItems = await _unitOfWork.PurchaseInvoiceItemRepository.FindAsync(c => c.Id == command.Id);

            if (PurchaseInvoiceItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPurchaseInvoiceItem = Mapper.Map(command);
            await _unitOfWork.PurchaseInvoiceItemRepository.AddAsync(newPurchaseInvoiceItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPurchaseInvoiceItemCommand command)
        {

            command.Validate();

            var PurchaseInvoiceItem = await _unitOfWork.PurchaseInvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PurchaseInvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseInvoiceItem = Mapper.Map(PurchaseInvoiceItem, command);
            PurchaseInvoiceItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PurchaseInvoiceItem = await _unitOfWork.PurchaseInvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PurchaseInvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseInvoiceItem.IsActive = false;
            PurchaseInvoiceItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PurchaseInvoiceItems = await _unitOfWork.PurchaseInvoiceItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PurchaseInvoiceItemsDto = Mapper.Map(PurchaseInvoiceItems);

            return OkResult(CustomMessage.DefaultMessage, PurchaseInvoiceItemsDto.ToPagingAndSorting(query), PurchaseInvoiceItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PurchaseInvoiceItem = await _unitOfWork.PurchaseInvoiceItemRepository.GetByIdAsync(id);

            if (PurchaseInvoiceItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PurchaseInvoiceItemDto = Mapper.Map(PurchaseInvoiceItem);

            return OkResult( CustomMessage.DefaultMessage , PurchaseInvoiceItemDto);

        }
    }
}
