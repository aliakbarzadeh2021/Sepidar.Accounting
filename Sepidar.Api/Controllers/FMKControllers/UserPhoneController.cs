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

namespace Sepidar.Api.Controllers.UserPhoneControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserPhoneController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserPhoneController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserPhoneCommand command)
        {
            command.Validate();

            var UserPhones = await _unitOfWork.UserPhoneRepository.FindAsync(c => c.Id == command.Id);

            if (UserPhones.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserPhone = Mapper.Map(command);
            await _unitOfWork.UserPhoneRepository.AddAsync(newUserPhone);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserPhoneCommand command)
        {

            command.Validate();

            var UserPhone = await _unitOfWork.UserPhoneRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserPhone == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserPhone = Mapper.Map(UserPhone, command);
            UserPhone.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserPhone = await _unitOfWork.UserPhoneRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserPhone == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserPhone.IsActive = false;
            UserPhone.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserPhones = await _unitOfWork.UserPhoneRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserPhonesDto = Mapper.Map(UserPhones);

            return OkResult(CustomMessage.DefaultMessage, UserPhonesDto.ToPagingAndSorting(query), UserPhonesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserPhone = await _unitOfWork.UserPhoneRepository.GetByIdAsync(id);

            if (UserPhone is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserPhoneDto = Mapper.Map(UserPhone);

            return OkResult( CustomMessage.DefaultMessage , UserPhoneDto);

        }
    }
}
