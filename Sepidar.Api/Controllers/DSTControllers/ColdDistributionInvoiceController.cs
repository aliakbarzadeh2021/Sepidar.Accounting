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

namespace Sepidar.Api.Controllers.ColdDistributionInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ColdDistributionInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ColdDistributionInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddColdDistributionInvoiceCommand command)
        {
            command.Validate();

            var ColdDistributionInvoices = await _unitOfWork.ColdDistributionInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (ColdDistributionInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newColdDistributionInvoice = Mapper.Map(command);
            await _unitOfWork.ColdDistributionInvoiceRepository.AddAsync(newColdDistributionInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditColdDistributionInvoiceCommand command)
        {

            command.Validate();

            var ColdDistributionInvoice = await _unitOfWork.ColdDistributionInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ColdDistributionInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ColdDistributionInvoice = Mapper.Map(ColdDistributionInvoice, command);
            ColdDistributionInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ColdDistributionInvoice = await _unitOfWork.ColdDistributionInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ColdDistributionInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ColdDistributionInvoice.IsActive = false;
            ColdDistributionInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ColdDistributionInvoices = await _unitOfWork.ColdDistributionInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ColdDistributionInvoicesDto = Mapper.Map(ColdDistributionInvoices);

            return OkResult(CustomMessage.DefaultMessage, ColdDistributionInvoicesDto.ToPagingAndSorting(query), ColdDistributionInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ColdDistributionInvoice = await _unitOfWork.ColdDistributionInvoiceRepository.GetByIdAsync(id);

            if (ColdDistributionInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ColdDistributionInvoiceDto = Mapper.Map(ColdDistributionInvoice);

            return OkResult( CustomMessage.DefaultMessage , ColdDistributionInvoiceDto);

        }
    }
}
