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

namespace Sepidar.Api.Controllers.POSInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class POSInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public POSInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPOSInvoiceCommand command)
        {
            command.Validate();

            var POSInvoices = await _unitOfWork.POSInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (POSInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPOSInvoice = Mapper.Map(command);
            await _unitOfWork.POSInvoiceRepository.AddAsync(newPOSInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPOSInvoiceCommand command)
        {

            command.Validate();

            var POSInvoice = await _unitOfWork.POSInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (POSInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSInvoice = Mapper.Map(POSInvoice, command);
            POSInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var POSInvoice = await _unitOfWork.POSInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (POSInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSInvoice.IsActive = false;
            POSInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var POSInvoices = await _unitOfWork.POSInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var POSInvoicesDto = Mapper.Map(POSInvoices);

            return OkResult(CustomMessage.DefaultMessage, POSInvoicesDto.ToPagingAndSorting(query), POSInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var POSInvoice = await _unitOfWork.POSInvoiceRepository.GetByIdAsync(id);

            if (POSInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var POSInvoiceDto = Mapper.Map(POSInvoice);

            return OkResult( CustomMessage.DefaultMessage , POSInvoiceDto);

        }
    }
}
