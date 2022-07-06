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

namespace Sepidar.Api.Controllers.InventoryPurchaseInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryPurchaseInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryPurchaseInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryPurchaseInvoiceCommand command)
        {
            command.Validate();

            var InventoryPurchaseInvoices = await _unitOfWork.InventoryPurchaseInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryPurchaseInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryPurchaseInvoice = Mapper.Map(command);
            await _unitOfWork.InventoryPurchaseInvoiceRepository.AddAsync(newInventoryPurchaseInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryPurchaseInvoiceCommand command)
        {

            command.Validate();

            var InventoryPurchaseInvoice = await _unitOfWork.InventoryPurchaseInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryPurchaseInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPurchaseInvoice = Mapper.Map(InventoryPurchaseInvoice, command);
            InventoryPurchaseInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryPurchaseInvoice = await _unitOfWork.InventoryPurchaseInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryPurchaseInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPurchaseInvoice.IsActive = false;
            InventoryPurchaseInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryPurchaseInvoices = await _unitOfWork.InventoryPurchaseInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryPurchaseInvoicesDto = Mapper.Map(InventoryPurchaseInvoices);

            return OkResult(CustomMessage.DefaultMessage, InventoryPurchaseInvoicesDto.ToPagingAndSorting(query), InventoryPurchaseInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryPurchaseInvoice = await _unitOfWork.InventoryPurchaseInvoiceRepository.GetByIdAsync(id);

            if (InventoryPurchaseInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryPurchaseInvoiceDto = Mapper.Map(InventoryPurchaseInvoice);

            return OkResult( CustomMessage.DefaultMessage , InventoryPurchaseInvoiceDto);

        }
    }
}
