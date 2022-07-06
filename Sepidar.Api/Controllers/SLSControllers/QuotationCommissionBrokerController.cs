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

namespace Sepidar.Api.Controllers.QuotationCommissionBrokerControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QuotationCommissionBrokerController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuotationCommissionBrokerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQuotationCommissionBrokerCommand command)
        {
            command.Validate();

            var QuotationCommissionBrokers = await _unitOfWork.QuotationCommissionBrokerRepository.FindAsync(c => c.Id == command.Id);

            if (QuotationCommissionBrokers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQuotationCommissionBroker = Mapper.Map(command);
            await _unitOfWork.QuotationCommissionBrokerRepository.AddAsync(newQuotationCommissionBroker);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQuotationCommissionBrokerCommand command)
        {

            command.Validate();

            var QuotationCommissionBroker = await _unitOfWork.QuotationCommissionBrokerRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QuotationCommissionBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuotationCommissionBroker = Mapper.Map(QuotationCommissionBroker, command);
            QuotationCommissionBroker.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QuotationCommissionBroker = await _unitOfWork.QuotationCommissionBrokerRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QuotationCommissionBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuotationCommissionBroker.IsActive = false;
            QuotationCommissionBroker.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QuotationCommissionBrokers = await _unitOfWork.QuotationCommissionBrokerRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QuotationCommissionBrokersDto = Mapper.Map(QuotationCommissionBrokers);

            return OkResult(CustomMessage.DefaultMessage, QuotationCommissionBrokersDto.ToPagingAndSorting(query), QuotationCommissionBrokersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QuotationCommissionBroker = await _unitOfWork.QuotationCommissionBrokerRepository.GetByIdAsync(id);

            if (QuotationCommissionBroker is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QuotationCommissionBrokerDto = Mapper.Map(QuotationCommissionBroker);

            return OkResult( CustomMessage.DefaultMessage , QuotationCommissionBrokerDto);

        }
    }
}
