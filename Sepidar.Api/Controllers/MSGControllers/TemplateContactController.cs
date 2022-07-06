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

namespace Sepidar.Api.Controllers.TemplateContactControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TemplateContactController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TemplateContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTemplateContactCommand command)
        {
            command.Validate();

            var TemplateContacts = await _unitOfWork.TemplateContactRepository.FindAsync(c => c.Id == command.Id);

            if (TemplateContacts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTemplateContact = Mapper.Map(command);
            await _unitOfWork.TemplateContactRepository.AddAsync(newTemplateContact);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTemplateContactCommand command)
        {

            command.Validate();

            var TemplateContact = await _unitOfWork.TemplateContactRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TemplateContact == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TemplateContact = Mapper.Map(TemplateContact, command);
            TemplateContact.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TemplateContact = await _unitOfWork.TemplateContactRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TemplateContact == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TemplateContact.IsActive = false;
            TemplateContact.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TemplateContacts = await _unitOfWork.TemplateContactRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TemplateContactsDto = Mapper.Map(TemplateContacts);

            return OkResult(CustomMessage.DefaultMessage, TemplateContactsDto.ToPagingAndSorting(query), TemplateContactsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TemplateContact = await _unitOfWork.TemplateContactRepository.GetByIdAsync(id);

            if (TemplateContact is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TemplateContactDto = Mapper.Map(TemplateContact);

            return OkResult( CustomMessage.DefaultMessage , TemplateContactDto);

        }
    }
}
