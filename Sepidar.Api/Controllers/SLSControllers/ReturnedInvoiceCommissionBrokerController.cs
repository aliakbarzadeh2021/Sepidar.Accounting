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

namespace Sepidar.Api.Controllers.ReturnedInvoiceCommissionBrokerControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReturnedInvoiceCommissionBrokerController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReturnedInvoiceCommissionBrokerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReturnedInvoiceCommissionBrokerCommand command)
        {
            command.Validate();

            var ReturnedInvoiceCommissionBrokers = await _unitOfWork.ReturnedInvoiceCommissionBrokerRepository.FindAsync(c => c.Id == command.Id);

            if (ReturnedInvoiceCommissionBrokers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReturnedInvoiceCommissionBroker = Mapper.Map(command);
            await _unitOfWork.ReturnedInvoiceCommissionBrokerRepository.AddAsync(newReturnedInvoiceCommissionBroker);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReturnedInvoiceCommissionBrokerCommand command)
        {

            command.Validate();

            var ReturnedInvoiceCommissionBroker = await _unitOfWork.ReturnedInvoiceCommissionBrokerRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoiceCommissionBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoiceCommissionBroker = Mapper.Map(ReturnedInvoiceCommissionBroker, command);
            ReturnedInvoiceCommissionBroker.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReturnedInvoiceCommissionBroker = await _unitOfWork.ReturnedInvoiceCommissionBrokerRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoiceCommissionBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoiceCommissionBroker.IsActive = false;
            ReturnedInvoiceCommissionBroker.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReturnedInvoiceCommissionBrokers = await _unitOfWork.ReturnedInvoiceCommissionBrokerRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReturnedInvoiceCommissionBrokersDto = Mapper.Map(ReturnedInvoiceCommissionBrokers);

            return OkResult(CustomMessage.DefaultMessage, ReturnedInvoiceCommissionBrokersDto.ToPagingAndSorting(query), ReturnedInvoiceCommissionBrokersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReturnedInvoiceCommissionBroker = await _unitOfWork.ReturnedInvoiceCommissionBrokerRepository.GetByIdAsync(id);

            if (ReturnedInvoiceCommissionBroker is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReturnedInvoiceCommissionBrokerDto = Mapper.Map(ReturnedInvoiceCommissionBroker);

            return OkResult( CustomMessage.DefaultMessage , ReturnedInvoiceCommissionBrokerDto);

        }
    }
}
