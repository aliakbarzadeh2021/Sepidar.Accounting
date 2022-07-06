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

namespace Sepidar.Api.Controllers.InvoiceCommissionBrokerControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceCommissionBrokerController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceCommissionBrokerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvoiceCommissionBrokerCommand command)
        {
            command.Validate();

            var InvoiceCommissionBrokers = await _unitOfWork.InvoiceCommissionBrokerRepository.FindAsync(c => c.Id == command.Id);

            if (InvoiceCommissionBrokers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvoiceCommissionBroker = Mapper.Map(command);
            await _unitOfWork.InvoiceCommissionBrokerRepository.AddAsync(newInvoiceCommissionBroker);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvoiceCommissionBrokerCommand command)
        {

            command.Validate();

            var InvoiceCommissionBroker = await _unitOfWork.InvoiceCommissionBrokerRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvoiceCommissionBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceCommissionBroker = Mapper.Map(InvoiceCommissionBroker, command);
            InvoiceCommissionBroker.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvoiceCommissionBroker = await _unitOfWork.InvoiceCommissionBrokerRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvoiceCommissionBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceCommissionBroker.IsActive = false;
            InvoiceCommissionBroker.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvoiceCommissionBrokers = await _unitOfWork.InvoiceCommissionBrokerRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvoiceCommissionBrokersDto = Mapper.Map(InvoiceCommissionBrokers);

            return OkResult(CustomMessage.DefaultMessage, InvoiceCommissionBrokersDto.ToPagingAndSorting(query), InvoiceCommissionBrokersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvoiceCommissionBroker = await _unitOfWork.InvoiceCommissionBrokerRepository.GetByIdAsync(id);

            if (InvoiceCommissionBroker is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvoiceCommissionBrokerDto = Mapper.Map(InvoiceCommissionBroker);

            return OkResult( CustomMessage.DefaultMessage , InvoiceCommissionBrokerDto);

        }
    }
}
