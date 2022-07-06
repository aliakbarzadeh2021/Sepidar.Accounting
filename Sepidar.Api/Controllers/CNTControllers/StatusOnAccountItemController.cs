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

namespace Sepidar.Api.Controllers.StatusOnAccountItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StatusOnAccountItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StatusOnAccountItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStatusOnAccountItemCommand command)
        {
            command.Validate();

            var StatusOnAccountItems = await _unitOfWork.StatusOnAccountItemRepository.FindAsync(c => c.Id == command.Id);

            if (StatusOnAccountItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStatusOnAccountItem = Mapper.Map(command);
            await _unitOfWork.StatusOnAccountItemRepository.AddAsync(newStatusOnAccountItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStatusOnAccountItemCommand command)
        {

            command.Validate();

            var StatusOnAccountItem = await _unitOfWork.StatusOnAccountItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StatusOnAccountItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StatusOnAccountItem = Mapper.Map(StatusOnAccountItem, command);
            StatusOnAccountItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StatusOnAccountItem = await _unitOfWork.StatusOnAccountItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StatusOnAccountItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StatusOnAccountItem.IsActive = false;
            StatusOnAccountItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StatusOnAccountItems = await _unitOfWork.StatusOnAccountItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StatusOnAccountItemsDto = Mapper.Map(StatusOnAccountItems);

            return OkResult(CustomMessage.DefaultMessage, StatusOnAccountItemsDto.ToPagingAndSorting(query), StatusOnAccountItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StatusOnAccountItem = await _unitOfWork.StatusOnAccountItemRepository.GetByIdAsync(id);

            if (StatusOnAccountItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StatusOnAccountItemDto = Mapper.Map(StatusOnAccountItem);

            return OkResult( CustomMessage.DefaultMessage , StatusOnAccountItemDto);

        }
    }
}
