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

namespace Sepidar.Api.Controllers.DebtCollectionListInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DebtCollectionListInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DebtCollectionListInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDebtCollectionListInvoiceCommand command)
        {
            command.Validate();

            var DebtCollectionListInvoices = await _unitOfWork.DebtCollectionListInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (DebtCollectionListInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDebtCollectionListInvoice = Mapper.Map(command);
            await _unitOfWork.DebtCollectionListInvoiceRepository.AddAsync(newDebtCollectionListInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDebtCollectionListInvoiceCommand command)
        {

            command.Validate();

            var DebtCollectionListInvoice = await _unitOfWork.DebtCollectionListInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DebtCollectionListInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DebtCollectionListInvoice = Mapper.Map(DebtCollectionListInvoice, command);
            DebtCollectionListInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DebtCollectionListInvoice = await _unitOfWork.DebtCollectionListInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DebtCollectionListInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DebtCollectionListInvoice.IsActive = false;
            DebtCollectionListInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DebtCollectionListInvoices = await _unitOfWork.DebtCollectionListInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DebtCollectionListInvoicesDto = Mapper.Map(DebtCollectionListInvoices);

            return OkResult(CustomMessage.DefaultMessage, DebtCollectionListInvoicesDto.ToPagingAndSorting(query), DebtCollectionListInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DebtCollectionListInvoice = await _unitOfWork.DebtCollectionListInvoiceRepository.GetByIdAsync(id);

            if (DebtCollectionListInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DebtCollectionListInvoiceDto = Mapper.Map(DebtCollectionListInvoice);

            return OkResult( CustomMessage.DefaultMessage , DebtCollectionListInvoiceDto);

        }
    }
}
