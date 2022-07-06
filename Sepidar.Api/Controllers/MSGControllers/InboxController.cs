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

namespace Sepidar.Api.Controllers.InboxControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InboxController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InboxController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInboxCommand command)
        {
            command.Validate();

            var Inboxs = await _unitOfWork.InboxRepository.FindAsync(c => c.Id == command.Id);

            if (Inboxs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInbox = Mapper.Map(command);
            await _unitOfWork.InboxRepository.AddAsync(newInbox);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInboxCommand command)
        {

            command.Validate();

            var Inbox = await _unitOfWork.InboxRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Inbox == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Inbox = Mapper.Map(Inbox, command);
            Inbox.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Inbox = await _unitOfWork.InboxRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Inbox == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Inbox.IsActive = false;
            Inbox.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Inboxs = await _unitOfWork.InboxRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InboxsDto = Mapper.Map(Inboxs);

            return OkResult(CustomMessage.DefaultMessage, InboxsDto.ToPagingAndSorting(query), InboxsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Inbox = await _unitOfWork.InboxRepository.GetByIdAsync(id);

            if (Inbox is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InboxDto = Mapper.Map(Inbox);

            return OkResult( CustomMessage.DefaultMessage , InboxDto);

        }
    }
}
