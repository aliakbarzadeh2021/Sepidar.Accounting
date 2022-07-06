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

namespace Sepidar.Api.Controllers.MessageContactControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MessageContactController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MessageContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMessageContactCommand command)
        {
            command.Validate();

            var MessageContacts = await _unitOfWork.MessageContactRepository.FindAsync(c => c.Id == command.Id);

            if (MessageContacts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMessageContact = Mapper.Map(command);
            await _unitOfWork.MessageContactRepository.AddAsync(newMessageContact);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMessageContactCommand command)
        {

            command.Validate();

            var MessageContact = await _unitOfWork.MessageContactRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MessageContact == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MessageContact = Mapper.Map(MessageContact, command);
            MessageContact.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MessageContact = await _unitOfWork.MessageContactRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MessageContact == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MessageContact.IsActive = false;
            MessageContact.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MessageContacts = await _unitOfWork.MessageContactRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MessageContactsDto = Mapper.Map(MessageContacts);

            return OkResult(CustomMessage.DefaultMessage, MessageContactsDto.ToPagingAndSorting(query), MessageContactsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MessageContact = await _unitOfWork.MessageContactRepository.GetByIdAsync(id);

            if (MessageContact is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MessageContactDto = Mapper.Map(MessageContact);

            return OkResult( CustomMessage.DefaultMessage , MessageContactDto);

        }
    }
}
