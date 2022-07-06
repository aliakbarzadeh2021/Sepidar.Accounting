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

namespace Sepidar.Api.Controllers.ReturnedInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReturnedInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReturnedInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReturnedInvoiceCommand command)
        {
            command.Validate();

            var ReturnedInvoices = await _unitOfWork.ReturnedInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (ReturnedInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReturnedInvoice = Mapper.Map(command);
            await _unitOfWork.ReturnedInvoiceRepository.AddAsync(newReturnedInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReturnedInvoiceCommand command)
        {

            command.Validate();

            var ReturnedInvoice = await _unitOfWork.ReturnedInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoice = Mapper.Map(ReturnedInvoice, command);
            ReturnedInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReturnedInvoice = await _unitOfWork.ReturnedInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoice.IsActive = false;
            ReturnedInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReturnedInvoices = await _unitOfWork.ReturnedInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReturnedInvoicesDto = Mapper.Map(ReturnedInvoices);

            return OkResult(CustomMessage.DefaultMessage, ReturnedInvoicesDto.ToPagingAndSorting(query), ReturnedInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReturnedInvoice = await _unitOfWork.ReturnedInvoiceRepository.GetByIdAsync(id);

            if (ReturnedInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReturnedInvoiceDto = Mapper.Map(ReturnedInvoice);

            return OkResult( CustomMessage.DefaultMessage , ReturnedInvoiceDto);

        }
    }
}
