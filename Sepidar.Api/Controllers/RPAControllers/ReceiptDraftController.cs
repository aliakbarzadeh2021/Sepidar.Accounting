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

namespace Sepidar.Api.Controllers.ReceiptDraftControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReceiptDraftController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReceiptDraftController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReceiptDraftCommand command)
        {
            command.Validate();

            var ReceiptDrafts = await _unitOfWork.ReceiptDraftRepository.FindAsync(c => c.Id == command.Id);

            if (ReceiptDrafts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReceiptDraft = Mapper.Map(command);
            await _unitOfWork.ReceiptDraftRepository.AddAsync(newReceiptDraft);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReceiptDraftCommand command)
        {

            command.Validate();

            var ReceiptDraft = await _unitOfWork.ReceiptDraftRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReceiptDraft == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptDraft = Mapper.Map(ReceiptDraft, command);
            ReceiptDraft.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReceiptDraft = await _unitOfWork.ReceiptDraftRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReceiptDraft == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptDraft.IsActive = false;
            ReceiptDraft.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReceiptDrafts = await _unitOfWork.ReceiptDraftRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReceiptDraftsDto = Mapper.Map(ReceiptDrafts);

            return OkResult(CustomMessage.DefaultMessage, ReceiptDraftsDto.ToPagingAndSorting(query), ReceiptDraftsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReceiptDraft = await _unitOfWork.ReceiptDraftRepository.GetByIdAsync(id);

            if (ReceiptDraft is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReceiptDraftDto = Mapper.Map(ReceiptDraft);

            return OkResult( CustomMessage.DefaultMessage , ReceiptDraftDto);

        }
    }
}
