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

namespace Sepidar.Api.Controllers.UserAccessControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserAccessController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserAccessController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserAccessCommand command)
        {
            command.Validate();

            var UserAccesss = await _unitOfWork.UserAccessRepository.FindAsync(c => c.Id == command.Id);

            if (UserAccesss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserAccess = Mapper.Map(command);
            await _unitOfWork.UserAccessRepository.AddAsync(newUserAccess);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserAccessCommand command)
        {

            command.Validate();

            var UserAccess = await _unitOfWork.UserAccessRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserAccess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserAccess = Mapper.Map(UserAccess, command);
            UserAccess.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserAccess = await _unitOfWork.UserAccessRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserAccess == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserAccess.IsActive = false;
            UserAccess.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserAccesss = await _unitOfWork.UserAccessRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserAccesssDto = Mapper.Map(UserAccesss);

            return OkResult(CustomMessage.DefaultMessage, UserAccesssDto.ToPagingAndSorting(query), UserAccesssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserAccess = await _unitOfWork.UserAccessRepository.GetByIdAsync(id);

            if (UserAccess is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserAccessDto = Mapper.Map(UserAccess);

            return OkResult( CustomMessage.DefaultMessage , UserAccessDto);

        }
    }
}
