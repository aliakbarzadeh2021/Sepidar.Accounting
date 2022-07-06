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

namespace Sepidar.Api.Controllers.ContractRelatedPurchaseInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractRelatedPurchaseInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractRelatedPurchaseInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractRelatedPurchaseInvoiceCommand command)
        {
            command.Validate();

            var ContractRelatedPurchaseInvoices = await _unitOfWork.ContractRelatedPurchaseInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (ContractRelatedPurchaseInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractRelatedPurchaseInvoice = Mapper.Map(command);
            await _unitOfWork.ContractRelatedPurchaseInvoiceRepository.AddAsync(newContractRelatedPurchaseInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractRelatedPurchaseInvoiceCommand command)
        {

            command.Validate();

            var ContractRelatedPurchaseInvoice = await _unitOfWork.ContractRelatedPurchaseInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractRelatedPurchaseInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractRelatedPurchaseInvoice = Mapper.Map(ContractRelatedPurchaseInvoice, command);
            ContractRelatedPurchaseInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractRelatedPurchaseInvoice = await _unitOfWork.ContractRelatedPurchaseInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractRelatedPurchaseInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractRelatedPurchaseInvoice.IsActive = false;
            ContractRelatedPurchaseInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractRelatedPurchaseInvoices = await _unitOfWork.ContractRelatedPurchaseInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractRelatedPurchaseInvoicesDto = Mapper.Map(ContractRelatedPurchaseInvoices);

            return OkResult(CustomMessage.DefaultMessage, ContractRelatedPurchaseInvoicesDto.ToPagingAndSorting(query), ContractRelatedPurchaseInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractRelatedPurchaseInvoice = await _unitOfWork.ContractRelatedPurchaseInvoiceRepository.GetByIdAsync(id);

            if (ContractRelatedPurchaseInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractRelatedPurchaseInvoiceDto = Mapper.Map(ContractRelatedPurchaseInvoice);

            return OkResult( CustomMessage.DefaultMessage , ContractRelatedPurchaseInvoiceDto);

        }
    }
}
