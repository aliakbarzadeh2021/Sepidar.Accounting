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

namespace Sepidar.Api.Controllers.InvoiceBrokerControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceBrokerController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceBrokerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvoiceBrokerCommand command)
        {
            command.Validate();

            var InvoiceBrokers = await _unitOfWork.InvoiceBrokerRepository.FindAsync(c => c.Id == command.Id);

            if (InvoiceBrokers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvoiceBroker = Mapper.Map(command);
            await _unitOfWork.InvoiceBrokerRepository.AddAsync(newInvoiceBroker);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvoiceBrokerCommand command)
        {

            command.Validate();

            var InvoiceBroker = await _unitOfWork.InvoiceBrokerRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvoiceBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceBroker = Mapper.Map(InvoiceBroker, command);
            InvoiceBroker.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvoiceBroker = await _unitOfWork.InvoiceBrokerRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvoiceBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceBroker.IsActive = false;
            InvoiceBroker.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvoiceBrokers = await _unitOfWork.InvoiceBrokerRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvoiceBrokersDto = Mapper.Map(InvoiceBrokers);

            return OkResult(CustomMessage.DefaultMessage, InvoiceBrokersDto.ToPagingAndSorting(query), InvoiceBrokersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvoiceBroker = await _unitOfWork.InvoiceBrokerRepository.GetByIdAsync(id);

            if (InvoiceBroker is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvoiceBrokerDto = Mapper.Map(InvoiceBroker);

            return OkResult( CustomMessage.DefaultMessage , InvoiceBrokerDto);

        }
    }
}
