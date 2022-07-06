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

namespace Sepidar.Api.Controllers.CustomContactControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CustomContactController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCustomContactCommand command)
        {
            command.Validate();

            var CustomContacts = await _unitOfWork.CustomContactRepository.FindAsync(c => c.Id == command.Id);

            if (CustomContacts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCustomContact = Mapper.Map(command);
            await _unitOfWork.CustomContactRepository.AddAsync(newCustomContact);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCustomContactCommand command)
        {

            command.Validate();

            var CustomContact = await _unitOfWork.CustomContactRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CustomContact == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CustomContact = Mapper.Map(CustomContact, command);
            CustomContact.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CustomContact = await _unitOfWork.CustomContactRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CustomContact == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CustomContact.IsActive = false;
            CustomContact.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CustomContacts = await _unitOfWork.CustomContactRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CustomContactsDto = Mapper.Map(CustomContacts);

            return OkResult(CustomMessage.DefaultMessage, CustomContactsDto.ToPagingAndSorting(query), CustomContactsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CustomContact = await _unitOfWork.CustomContactRepository.GetByIdAsync(id);

            if (CustomContact is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CustomContactDto = Mapper.Map(CustomContact);

            return OkResult( CustomMessage.DefaultMessage , CustomContactDto);

        }
    }
}
