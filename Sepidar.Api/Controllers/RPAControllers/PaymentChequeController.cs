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

namespace Sepidar.Api.Controllers.PaymentChequeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentChequeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentChequeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaymentChequeCommand command)
        {
            command.Validate();

            var PaymentCheques = await _unitOfWork.PaymentChequeRepository.FindAsync(c => c.Id == command.Id);

            if (PaymentCheques.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaymentCheque = Mapper.Map(command);
            await _unitOfWork.PaymentChequeRepository.AddAsync(newPaymentCheque);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaymentChequeCommand command)
        {

            command.Validate();

            var PaymentCheque = await _unitOfWork.PaymentChequeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaymentCheque == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentCheque = Mapper.Map(PaymentCheque, command);
            PaymentCheque.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaymentCheque = await _unitOfWork.PaymentChequeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaymentCheque == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentCheque.IsActive = false;
            PaymentCheque.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaymentCheques = await _unitOfWork.PaymentChequeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaymentChequesDto = Mapper.Map(PaymentCheques);

            return OkResult(CustomMessage.DefaultMessage, PaymentChequesDto.ToPagingAndSorting(query), PaymentChequesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaymentCheque = await _unitOfWork.PaymentChequeRepository.GetByIdAsync(id);

            if (PaymentCheque is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaymentChequeDto = Mapper.Map(PaymentCheque);

            return OkResult( CustomMessage.DefaultMessage , PaymentChequeDto);

        }
    }
}
