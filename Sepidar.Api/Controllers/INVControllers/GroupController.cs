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

namespace Sepidar.Api.Controllers.GroupControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGroupCommand command)
        {
            command.Validate();

            var Groups = await _unitOfWork.GroupRepository.FindAsync(c => c.Id == command.Id);

            if (Groups.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGroup = Mapper.Map(command);
            await _unitOfWork.GroupRepository.AddAsync(newGroup);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGroupCommand command)
        {

            command.Validate();

            var Group = await _unitOfWork.GroupRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Group == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Group = Mapper.Map(Group, command);
            Group.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Group = await _unitOfWork.GroupRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Group == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Group.IsActive = false;
            Group.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Groups = await _unitOfWork.GroupRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GroupsDto = Mapper.Map(Groups);

            return OkResult(CustomMessage.DefaultMessage, GroupsDto.ToPagingAndSorting(query), GroupsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Group = await _unitOfWork.GroupRepository.GetByIdAsync(id);

            if (Group is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GroupDto = Mapper.Map(Group);

            return OkResult( CustomMessage.DefaultMessage , GroupDto);

        }
    }
}
