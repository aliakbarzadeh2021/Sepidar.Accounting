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

namespace Sepidar.Api.Controllers.PartyPhoneControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartyPhoneController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartyPhoneController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartyPhoneCommand command)
        {
            command.Validate();

            var PartyPhones = await _unitOfWork.PartyPhoneRepository.FindAsync(c => c.Id == command.Id);

            if (PartyPhones.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartyPhone = Mapper.Map(command);
            await _unitOfWork.PartyPhoneRepository.AddAsync(newPartyPhone);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartyPhoneCommand command)
        {

            command.Validate();

            var PartyPhone = await _unitOfWork.PartyPhoneRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartyPhone == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyPhone = Mapper.Map(PartyPhone, command);
            PartyPhone.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartyPhone = await _unitOfWork.PartyPhoneRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartyPhone == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyPhone.IsActive = false;
            PartyPhone.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartyPhones = await _unitOfWork.PartyPhoneRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartyPhonesDto = Mapper.Map(PartyPhones);

            return OkResult(CustomMessage.DefaultMessage, PartyPhonesDto.ToPagingAndSorting(query), PartyPhonesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartyPhone = await _unitOfWork.PartyPhoneRepository.GetByIdAsync(id);

            if (PartyPhone is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartyPhoneDto = Mapper.Map(PartyPhone);

            return OkResult( CustomMessage.DefaultMessage , PartyPhoneDto);

        }
    }
}
