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

namespace Sepidar.Api.Controllers.GroupingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GroupingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GroupingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGroupingCommand command)
        {
            command.Validate();

            var Groupings = await _unitOfWork.GroupingRepository.FindAsync(c => c.Id == command.Id);

            if (Groupings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGrouping = Mapper.Map(command);
            await _unitOfWork.GroupingRepository.AddAsync(newGrouping);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGroupingCommand command)
        {

            command.Validate();

            var Grouping = await _unitOfWork.GroupingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Grouping == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Grouping = Mapper.Map(Grouping, command);
            Grouping.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Grouping = await _unitOfWork.GroupingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Grouping == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Grouping.IsActive = false;
            Grouping.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Groupings = await _unitOfWork.GroupingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GroupingsDto = Mapper.Map(Groupings);

            return OkResult(CustomMessage.DefaultMessage, GroupingsDto.ToPagingAndSorting(query), GroupingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Grouping = await _unitOfWork.GroupingRepository.GetByIdAsync(id);

            if (Grouping is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GroupingDto = Mapper.Map(Grouping);

            return OkResult( CustomMessage.DefaultMessage , GroupingDto);

        }
    }
}
