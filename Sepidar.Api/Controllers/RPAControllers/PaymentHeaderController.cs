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

namespace Sepidar.Api.Controllers.PaymentHeaderControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentHeaderController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentHeaderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaymentHeaderCommand command)
        {
            command.Validate();

            var PaymentHeaders = await _unitOfWork.PaymentHeaderRepository.FindAsync(c => c.Id == command.Id);

            if (PaymentHeaders.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaymentHeader = Mapper.Map(command);
            await _unitOfWork.PaymentHeaderRepository.AddAsync(newPaymentHeader);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaymentHeaderCommand command)
        {

            command.Validate();

            var PaymentHeader = await _unitOfWork.PaymentHeaderRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaymentHeader == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentHeader = Mapper.Map(PaymentHeader, command);
            PaymentHeader.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaymentHeader = await _unitOfWork.PaymentHeaderRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaymentHeader == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentHeader.IsActive = false;
            PaymentHeader.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaymentHeaders = await _unitOfWork.PaymentHeaderRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaymentHeadersDto = Mapper.Map(PaymentHeaders);

            return OkResult(CustomMessage.DefaultMessage, PaymentHeadersDto.ToPagingAndSorting(query), PaymentHeadersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaymentHeader = await _unitOfWork.PaymentHeaderRepository.GetByIdAsync(id);

            if (PaymentHeader is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaymentHeaderDto = Mapper.Map(PaymentHeader);

            return OkResult( CustomMessage.DefaultMessage , PaymentHeaderDto);

        }
    }
}
