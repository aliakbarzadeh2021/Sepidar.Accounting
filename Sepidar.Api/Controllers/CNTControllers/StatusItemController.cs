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

namespace Sepidar.Api.Controllers.StatusItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StatusItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StatusItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStatusItemCommand command)
        {
            command.Validate();

            var StatusItems = await _unitOfWork.StatusItemRepository.FindAsync(c => c.Id == command.Id);

            if (StatusItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStatusItem = Mapper.Map(command);
            await _unitOfWork.StatusItemRepository.AddAsync(newStatusItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStatusItemCommand command)
        {

            command.Validate();

            var StatusItem = await _unitOfWork.StatusItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StatusItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StatusItem = Mapper.Map(StatusItem, command);
            StatusItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StatusItem = await _unitOfWork.StatusItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StatusItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StatusItem.IsActive = false;
            StatusItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StatusItems = await _unitOfWork.StatusItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StatusItemsDto = Mapper.Map(StatusItems);

            return OkResult(CustomMessage.DefaultMessage, StatusItemsDto.ToPagingAndSorting(query), StatusItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StatusItem = await _unitOfWork.StatusItemRepository.GetByIdAsync(id);

            if (StatusItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StatusItemDto = Mapper.Map(StatusItem);

            return OkResult( CustomMessage.DefaultMessage , StatusItemDto);

        }
    }
}
