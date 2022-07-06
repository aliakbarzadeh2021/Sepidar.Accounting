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

namespace Sepidar.Api.Controllers.ChangeItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ChangeItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChangeItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddChangeItemCommand command)
        {
            command.Validate();

            var ChangeItems = await _unitOfWork.ChangeItemRepository.FindAsync(c => c.Id == command.Id);

            if (ChangeItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newChangeItem = Mapper.Map(command);
            await _unitOfWork.ChangeItemRepository.AddAsync(newChangeItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditChangeItemCommand command)
        {

            command.Validate();

            var ChangeItem = await _unitOfWork.ChangeItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ChangeItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ChangeItem = Mapper.Map(ChangeItem, command);
            ChangeItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ChangeItem = await _unitOfWork.ChangeItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ChangeItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ChangeItem.IsActive = false;
            ChangeItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ChangeItems = await _unitOfWork.ChangeItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ChangeItemsDto = Mapper.Map(ChangeItems);

            return OkResult(CustomMessage.DefaultMessage, ChangeItemsDto.ToPagingAndSorting(query), ChangeItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ChangeItem = await _unitOfWork.ChangeItemRepository.GetByIdAsync(id);

            if (ChangeItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ChangeItemDto = Mapper.Map(ChangeItem);

            return OkResult( CustomMessage.DefaultMessage , ChangeItemDto);

        }
    }
}
