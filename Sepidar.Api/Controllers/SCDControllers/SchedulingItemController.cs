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

namespace Sepidar.Api.Controllers.SchedulingItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SchedulingItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SchedulingItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSchedulingItemCommand command)
        {
            command.Validate();

            var SchedulingItems = await _unitOfWork.SchedulingItemRepository.FindAsync(c => c.Id == command.Id);

            if (SchedulingItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSchedulingItem = Mapper.Map(command);
            await _unitOfWork.SchedulingItemRepository.AddAsync(newSchedulingItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSchedulingItemCommand command)
        {

            command.Validate();

            var SchedulingItem = await _unitOfWork.SchedulingItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SchedulingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SchedulingItem = Mapper.Map(SchedulingItem, command);
            SchedulingItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SchedulingItem = await _unitOfWork.SchedulingItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SchedulingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SchedulingItem.IsActive = false;
            SchedulingItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SchedulingItems = await _unitOfWork.SchedulingItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SchedulingItemsDto = Mapper.Map(SchedulingItems);

            return OkResult(CustomMessage.DefaultMessage, SchedulingItemsDto.ToPagingAndSorting(query), SchedulingItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SchedulingItem = await _unitOfWork.SchedulingItemRepository.GetByIdAsync(id);

            if (SchedulingItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SchedulingItemDto = Mapper.Map(SchedulingItem);

            return OkResult( CustomMessage.DefaultMessage , SchedulingItemDto);

        }
    }
}
