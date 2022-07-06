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

namespace Sepidar.Api.Controllers.InvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvoiceCommand command)
        {
            command.Validate();

            var Invoices = await _unitOfWork.InvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (Invoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvoice = Mapper.Map(command);
            await _unitOfWork.InvoiceRepository.AddAsync(newInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvoiceCommand command)
        {

            command.Validate();

            var Invoice = await _unitOfWork.InvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Invoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Invoice = Mapper.Map(Invoice, command);
            Invoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Invoice = await _unitOfWork.InvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Invoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Invoice.IsActive = false;
            Invoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Invoices = await _unitOfWork.InvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvoicesDto = Mapper.Map(Invoices);

            return OkResult(CustomMessage.DefaultMessage, InvoicesDto.ToPagingAndSorting(query), InvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Invoice = await _unitOfWork.InvoiceRepository.GetByIdAsync(id);

            if (Invoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvoiceDto = Mapper.Map(Invoice);

            return OkResult( CustomMessage.DefaultMessage , InvoiceDto);

        }
    }
}
