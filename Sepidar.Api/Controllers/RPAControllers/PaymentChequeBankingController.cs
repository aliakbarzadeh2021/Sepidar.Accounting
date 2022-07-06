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

namespace Sepidar.Api.Controllers.PaymentChequeBankingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentChequeBankingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentChequeBankingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaymentChequeBankingCommand command)
        {
            command.Validate();

            var PaymentChequeBankings = await _unitOfWork.PaymentChequeBankingRepository.FindAsync(c => c.Id == command.Id);

            if (PaymentChequeBankings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaymentChequeBanking = Mapper.Map(command);
            await _unitOfWork.PaymentChequeBankingRepository.AddAsync(newPaymentChequeBanking);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaymentChequeBankingCommand command)
        {

            command.Validate();

            var PaymentChequeBanking = await _unitOfWork.PaymentChequeBankingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaymentChequeBanking == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentChequeBanking = Mapper.Map(PaymentChequeBanking, command);
            PaymentChequeBanking.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaymentChequeBanking = await _unitOfWork.PaymentChequeBankingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaymentChequeBanking == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentChequeBanking.IsActive = false;
            PaymentChequeBanking.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaymentChequeBankings = await _unitOfWork.PaymentChequeBankingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaymentChequeBankingsDto = Mapper.Map(PaymentChequeBankings);

            return OkResult(CustomMessage.DefaultMessage, PaymentChequeBankingsDto.ToPagingAndSorting(query), PaymentChequeBankingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaymentChequeBanking = await _unitOfWork.PaymentChequeBankingRepository.GetByIdAsync(id);

            if (PaymentChequeBanking is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaymentChequeBankingDto = Mapper.Map(PaymentChequeBanking);

            return OkResult( CustomMessage.DefaultMessage , PaymentChequeBankingDto);

        }
    }
}
