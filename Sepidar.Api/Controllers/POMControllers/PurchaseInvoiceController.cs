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

namespace Sepidar.Api.Controllers.PurchaseInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PurchaseInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPurchaseInvoiceCommand command)
        {
            command.Validate();

            var PurchaseInvoices = await _unitOfWork.PurchaseInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (PurchaseInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPurchaseInvoice = Mapper.Map(command);
            await _unitOfWork.PurchaseInvoiceRepository.AddAsync(newPurchaseInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPurchaseInvoiceCommand command)
        {

            command.Validate();

            var PurchaseInvoice = await _unitOfWork.PurchaseInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PurchaseInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseInvoice = Mapper.Map(PurchaseInvoice, command);
            PurchaseInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PurchaseInvoice = await _unitOfWork.PurchaseInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PurchaseInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseInvoice.IsActive = false;
            PurchaseInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PurchaseInvoices = await _unitOfWork.PurchaseInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PurchaseInvoicesDto = Mapper.Map(PurchaseInvoices);

            return OkResult(CustomMessage.DefaultMessage, PurchaseInvoicesDto.ToPagingAndSorting(query), PurchaseInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PurchaseInvoice = await _unitOfWork.PurchaseInvoiceRepository.GetByIdAsync(id);

            if (PurchaseInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PurchaseInvoiceDto = Mapper.Map(PurchaseInvoice);

            return OkResult( CustomMessage.DefaultMessage , PurchaseInvoiceDto);

        }
    }
}
