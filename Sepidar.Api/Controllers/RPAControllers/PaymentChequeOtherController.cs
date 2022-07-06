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

namespace Sepidar.Api.Controllers.PaymentChequeOtherControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentChequeOtherController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentChequeOtherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaymentChequeOtherCommand command)
        {
            command.Validate();

            var PaymentChequeOthers = await _unitOfWork.PaymentChequeOtherRepository.FindAsync(c => c.Id == command.Id);

            if (PaymentChequeOthers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaymentChequeOther = Mapper.Map(command);
            await _unitOfWork.PaymentChequeOtherRepository.AddAsync(newPaymentChequeOther);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaymentChequeOtherCommand command)
        {

            command.Validate();

            var PaymentChequeOther = await _unitOfWork.PaymentChequeOtherRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaymentChequeOther == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentChequeOther = Mapper.Map(PaymentChequeOther, command);
            PaymentChequeOther.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaymentChequeOther = await _unitOfWork.PaymentChequeOtherRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaymentChequeOther == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentChequeOther.IsActive = false;
            PaymentChequeOther.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaymentChequeOthers = await _unitOfWork.PaymentChequeOtherRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaymentChequeOthersDto = Mapper.Map(PaymentChequeOthers);

            return OkResult(CustomMessage.DefaultMessage, PaymentChequeOthersDto.ToPagingAndSorting(query), PaymentChequeOthersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaymentChequeOther = await _unitOfWork.PaymentChequeOtherRepository.GetByIdAsync(id);

            if (PaymentChequeOther is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaymentChequeOtherDto = Mapper.Map(PaymentChequeOther);

            return OkResult( CustomMessage.DefaultMessage , PaymentChequeOtherDto);

        }
    }
}
