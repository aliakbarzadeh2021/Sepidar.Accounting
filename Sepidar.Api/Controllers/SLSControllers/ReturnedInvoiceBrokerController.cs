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

namespace Sepidar.Api.Controllers.ReturnedInvoiceBrokerControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReturnedInvoiceBrokerController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReturnedInvoiceBrokerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReturnedInvoiceBrokerCommand command)
        {
            command.Validate();

            var ReturnedInvoiceBrokers = await _unitOfWork.ReturnedInvoiceBrokerRepository.FindAsync(c => c.Id == command.Id);

            if (ReturnedInvoiceBrokers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReturnedInvoiceBroker = Mapper.Map(command);
            await _unitOfWork.ReturnedInvoiceBrokerRepository.AddAsync(newReturnedInvoiceBroker);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReturnedInvoiceBrokerCommand command)
        {

            command.Validate();

            var ReturnedInvoiceBroker = await _unitOfWork.ReturnedInvoiceBrokerRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoiceBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoiceBroker = Mapper.Map(ReturnedInvoiceBroker, command);
            ReturnedInvoiceBroker.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReturnedInvoiceBroker = await _unitOfWork.ReturnedInvoiceBrokerRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoiceBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoiceBroker.IsActive = false;
            ReturnedInvoiceBroker.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReturnedInvoiceBrokers = await _unitOfWork.ReturnedInvoiceBrokerRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReturnedInvoiceBrokersDto = Mapper.Map(ReturnedInvoiceBrokers);

            return OkResult(CustomMessage.DefaultMessage, ReturnedInvoiceBrokersDto.ToPagingAndSorting(query), ReturnedInvoiceBrokersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReturnedInvoiceBroker = await _unitOfWork.ReturnedInvoiceBrokerRepository.GetByIdAsync(id);

            if (ReturnedInvoiceBroker is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReturnedInvoiceBrokerDto = Mapper.Map(ReturnedInvoiceBroker);

            return OkResult( CustomMessage.DefaultMessage , ReturnedInvoiceBrokerDto);

        }
    }
}
