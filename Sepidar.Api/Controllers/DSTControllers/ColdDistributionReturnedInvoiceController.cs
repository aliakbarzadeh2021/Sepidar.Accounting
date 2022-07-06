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

namespace Sepidar.Api.Controllers.ColdDistributionReturnedInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ColdDistributionReturnedInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ColdDistributionReturnedInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddColdDistributionReturnedInvoiceCommand command)
        {
            command.Validate();

            var ColdDistributionReturnedInvoices = await _unitOfWork.ColdDistributionReturnedInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (ColdDistributionReturnedInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newColdDistributionReturnedInvoice = Mapper.Map(command);
            await _unitOfWork.ColdDistributionReturnedInvoiceRepository.AddAsync(newColdDistributionReturnedInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditColdDistributionReturnedInvoiceCommand command)
        {

            command.Validate();

            var ColdDistributionReturnedInvoice = await _unitOfWork.ColdDistributionReturnedInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ColdDistributionReturnedInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ColdDistributionReturnedInvoice = Mapper.Map(ColdDistributionReturnedInvoice, command);
            ColdDistributionReturnedInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ColdDistributionReturnedInvoice = await _unitOfWork.ColdDistributionReturnedInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ColdDistributionReturnedInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ColdDistributionReturnedInvoice.IsActive = false;
            ColdDistributionReturnedInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ColdDistributionReturnedInvoices = await _unitOfWork.ColdDistributionReturnedInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ColdDistributionReturnedInvoicesDto = Mapper.Map(ColdDistributionReturnedInvoices);

            return OkResult(CustomMessage.DefaultMessage, ColdDistributionReturnedInvoicesDto.ToPagingAndSorting(query), ColdDistributionReturnedInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ColdDistributionReturnedInvoice = await _unitOfWork.ColdDistributionReturnedInvoiceRepository.GetByIdAsync(id);

            if (ColdDistributionReturnedInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ColdDistributionReturnedInvoiceDto = Mapper.Map(ColdDistributionReturnedInvoice);

            return OkResult( CustomMessage.DefaultMessage , ColdDistributionReturnedInvoiceDto);

        }
    }
}
