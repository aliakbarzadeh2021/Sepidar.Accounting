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

namespace Sepidar.Api.Controllers.OutgoingMessageControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OutgoingMessageController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OutgoingMessageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOutgoingMessageCommand command)
        {
            command.Validate();

            var OutgoingMessages = await _unitOfWork.OutgoingMessageRepository.FindAsync(c => c.Id == command.Id);

            if (OutgoingMessages.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOutgoingMessage = Mapper.Map(command);
            await _unitOfWork.OutgoingMessageRepository.AddAsync(newOutgoingMessage);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOutgoingMessageCommand command)
        {

            command.Validate();

            var OutgoingMessage = await _unitOfWork.OutgoingMessageRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OutgoingMessage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OutgoingMessage = Mapper.Map(OutgoingMessage, command);
            OutgoingMessage.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OutgoingMessage = await _unitOfWork.OutgoingMessageRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OutgoingMessage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OutgoingMessage.IsActive = false;
            OutgoingMessage.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OutgoingMessages = await _unitOfWork.OutgoingMessageRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OutgoingMessagesDto = Mapper.Map(OutgoingMessages);

            return OkResult(CustomMessage.DefaultMessage, OutgoingMessagesDto.ToPagingAndSorting(query), OutgoingMessagesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OutgoingMessage = await _unitOfWork.OutgoingMessageRepository.GetByIdAsync(id);

            if (OutgoingMessage is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OutgoingMessageDto = Mapper.Map(OutgoingMessage);

            return OkResult( CustomMessage.DefaultMessage , OutgoingMessageDto);

        }
    }
}
