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

namespace Sepidar.Api.Controllers.UserReportsInvisibleControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserReportsInvisibleController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserReportsInvisibleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserReportsInvisibleCommand command)
        {
            command.Validate();

            var UserReportsInvisibles = await _unitOfWork.UserReportsInvisibleRepository.FindAsync(c => c.Id == command.Id);

            if (UserReportsInvisibles.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserReportsInvisible = Mapper.Map(command);
            await _unitOfWork.UserReportsInvisibleRepository.AddAsync(newUserReportsInvisible);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserReportsInvisibleCommand command)
        {

            command.Validate();

            var UserReportsInvisible = await _unitOfWork.UserReportsInvisibleRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserReportsInvisible == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserReportsInvisible = Mapper.Map(UserReportsInvisible, command);
            UserReportsInvisible.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserReportsInvisible = await _unitOfWork.UserReportsInvisibleRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserReportsInvisible == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserReportsInvisible.IsActive = false;
            UserReportsInvisible.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserReportsInvisibles = await _unitOfWork.UserReportsInvisibleRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserReportsInvisiblesDto = Mapper.Map(UserReportsInvisibles);

            return OkResult(CustomMessage.DefaultMessage, UserReportsInvisiblesDto.ToPagingAndSorting(query), UserReportsInvisiblesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserReportsInvisible = await _unitOfWork.UserReportsInvisibleRepository.GetByIdAsync(id);

            if (UserReportsInvisible is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserReportsInvisibleDto = Mapper.Map(UserReportsInvisible);

            return OkResult( CustomMessage.DefaultMessage , UserReportsInvisibleDto);

        }
    }
}
