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

namespace Sepidar.Api.Controllers.PaymentChequeHistoryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentChequeHistoryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentChequeHistoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaymentChequeHistoryCommand command)
        {
            command.Validate();

            var PaymentChequeHistorys = await _unitOfWork.PaymentChequeHistoryRepository.FindAsync(c => c.Id == command.Id);

            if (PaymentChequeHistorys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaymentChequeHistory = Mapper.Map(command);
            await _unitOfWork.PaymentChequeHistoryRepository.AddAsync(newPaymentChequeHistory);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaymentChequeHistoryCommand command)
        {

            command.Validate();

            var PaymentChequeHistory = await _unitOfWork.PaymentChequeHistoryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaymentChequeHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentChequeHistory = Mapper.Map(PaymentChequeHistory, command);
            PaymentChequeHistory.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaymentChequeHistory = await _unitOfWork.PaymentChequeHistoryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaymentChequeHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentChequeHistory.IsActive = false;
            PaymentChequeHistory.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaymentChequeHistorys = await _unitOfWork.PaymentChequeHistoryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaymentChequeHistorysDto = Mapper.Map(PaymentChequeHistorys);

            return OkResult(CustomMessage.DefaultMessage, PaymentChequeHistorysDto.ToPagingAndSorting(query), PaymentChequeHistorysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaymentChequeHistory = await _unitOfWork.PaymentChequeHistoryRepository.GetByIdAsync(id);

            if (PaymentChequeHistory is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaymentChequeHistoryDto = Mapper.Map(PaymentChequeHistory);

            return OkResult( CustomMessage.DefaultMessage , PaymentChequeHistoryDto);

        }
    }
}
