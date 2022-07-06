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

namespace Sepidar.Api.Controllers.POSReturnedInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class POSReturnedInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public POSReturnedInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPOSReturnedInvoiceCommand command)
        {
            command.Validate();

            var POSReturnedInvoices = await _unitOfWork.POSReturnedInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (POSReturnedInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPOSReturnedInvoice = Mapper.Map(command);
            await _unitOfWork.POSReturnedInvoiceRepository.AddAsync(newPOSReturnedInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPOSReturnedInvoiceCommand command)
        {

            command.Validate();

            var POSReturnedInvoice = await _unitOfWork.POSReturnedInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (POSReturnedInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSReturnedInvoice = Mapper.Map(POSReturnedInvoice, command);
            POSReturnedInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var POSReturnedInvoice = await _unitOfWork.POSReturnedInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (POSReturnedInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSReturnedInvoice.IsActive = false;
            POSReturnedInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var POSReturnedInvoices = await _unitOfWork.POSReturnedInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var POSReturnedInvoicesDto = Mapper.Map(POSReturnedInvoices);

            return OkResult(CustomMessage.DefaultMessage, POSReturnedInvoicesDto.ToPagingAndSorting(query), POSReturnedInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var POSReturnedInvoice = await _unitOfWork.POSReturnedInvoiceRepository.GetByIdAsync(id);

            if (POSReturnedInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var POSReturnedInvoiceDto = Mapper.Map(POSReturnedInvoice);

            return OkResult( CustomMessage.DefaultMessage , POSReturnedInvoiceDto);

        }
    }
}
