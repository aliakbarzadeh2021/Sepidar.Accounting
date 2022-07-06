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

namespace Sepidar.Api.Controllers.PaymentDraftControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentDraftController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentDraftController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaymentDraftCommand command)
        {
            command.Validate();

            var PaymentDrafts = await _unitOfWork.PaymentDraftRepository.FindAsync(c => c.Id == command.Id);

            if (PaymentDrafts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaymentDraft = Mapper.Map(command);
            await _unitOfWork.PaymentDraftRepository.AddAsync(newPaymentDraft);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaymentDraftCommand command)
        {

            command.Validate();

            var PaymentDraft = await _unitOfWork.PaymentDraftRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaymentDraft == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentDraft = Mapper.Map(PaymentDraft, command);
            PaymentDraft.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaymentDraft = await _unitOfWork.PaymentDraftRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaymentDraft == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentDraft.IsActive = false;
            PaymentDraft.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaymentDrafts = await _unitOfWork.PaymentDraftRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaymentDraftsDto = Mapper.Map(PaymentDrafts);

            return OkResult(CustomMessage.DefaultMessage, PaymentDraftsDto.ToPagingAndSorting(query), PaymentDraftsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaymentDraft = await _unitOfWork.PaymentDraftRepository.GetByIdAsync(id);

            if (PaymentDraft is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaymentDraftDto = Mapper.Map(PaymentDraft);

            return OkResult( CustomMessage.DefaultMessage , PaymentDraftDto);

        }
    }
}
