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

namespace Sepidar.Api.Controllers.UserControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserCommand command)
        {
            command.Validate();

            var Users = await _unitOfWork.UserRepository.FindAsync(c => c.Id == command.Id);

            if (Users.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUser = Mapper.Map(command);
            await _unitOfWork.UserRepository.AddAsync(newUser);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserCommand command)
        {

            command.Validate();

            var User = await _unitOfWork.UserRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (User == null)
                return NotFound(CustomMessage.NotFoundMessage);

            User = Mapper.Map(User, command);
            User.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var User = await _unitOfWork.UserRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (User == null)
                return NotFound(CustomMessage.NotFoundMessage);

            User.IsActive = false;
            User.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Users = await _unitOfWork.UserRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UsersDto = Mapper.Map(Users);

            return OkResult(CustomMessage.DefaultMessage, UsersDto.ToPagingAndSorting(query), UsersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var User = await _unitOfWork.UserRepository.GetByIdAsync(id);

            if (User is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserDto = Mapper.Map(User);

            return OkResult( CustomMessage.DefaultMessage , UserDto);

        }
    }
}
