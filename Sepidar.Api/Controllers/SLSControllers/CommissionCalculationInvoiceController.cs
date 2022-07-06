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

namespace Sepidar.Api.Controllers.CommissionCalculationInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionCalculationInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommissionCalculationInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommissionCalculationInvoiceCommand command)
        {
            command.Validate();

            var CommissionCalculationInvoices = await _unitOfWork.CommissionCalculationInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (CommissionCalculationInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommissionCalculationInvoice = Mapper.Map(command);
            await _unitOfWork.CommissionCalculationInvoiceRepository.AddAsync(newCommissionCalculationInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommissionCalculationInvoiceCommand command)
        {

            command.Validate();

            var CommissionCalculationInvoice = await _unitOfWork.CommissionCalculationInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommissionCalculationInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionCalculationInvoice = Mapper.Map(CommissionCalculationInvoice, command);
            CommissionCalculationInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommissionCalculationInvoice = await _unitOfWork.CommissionCalculationInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommissionCalculationInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionCalculationInvoice.IsActive = false;
            CommissionCalculationInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommissionCalculationInvoices = await _unitOfWork.CommissionCalculationInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommissionCalculationInvoicesDto = Mapper.Map(CommissionCalculationInvoices);

            return OkResult(CustomMessage.DefaultMessage, CommissionCalculationInvoicesDto.ToPagingAndSorting(query), CommissionCalculationInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommissionCalculationInvoice = await _unitOfWork.CommissionCalculationInvoiceRepository.GetByIdAsync(id);

            if (CommissionCalculationInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommissionCalculationInvoiceDto = Mapper.Map(CommissionCalculationInvoice);

            return OkResult( CustomMessage.DefaultMessage , CommissionCalculationInvoiceDto);

        }
    }
}
