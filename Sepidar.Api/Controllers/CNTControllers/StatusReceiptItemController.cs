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

namespace Sepidar.Api.Controllers.StatusReceiptItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StatusReceiptItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StatusReceiptItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStatusReceiptItemCommand command)
        {
            command.Validate();

            var StatusReceiptItems = await _unitOfWork.StatusReceiptItemRepository.FindAsync(c => c.Id == command.Id);

            if (StatusReceiptItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStatusReceiptItem = Mapper.Map(command);
            await _unitOfWork.StatusReceiptItemRepository.AddAsync(newStatusReceiptItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStatusReceiptItemCommand command)
        {

            command.Validate();

            var StatusReceiptItem = await _unitOfWork.StatusReceiptItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StatusReceiptItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StatusReceiptItem = Mapper.Map(StatusReceiptItem, command);
            StatusReceiptItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StatusReceiptItem = await _unitOfWork.StatusReceiptItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StatusReceiptItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StatusReceiptItem.IsActive = false;
            StatusReceiptItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StatusReceiptItems = await _unitOfWork.StatusReceiptItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StatusReceiptItemsDto = Mapper.Map(StatusReceiptItems);

            return OkResult(CustomMessage.DefaultMessage, StatusReceiptItemsDto.ToPagingAndSorting(query), StatusReceiptItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StatusReceiptItem = await _unitOfWork.StatusReceiptItemRepository.GetByIdAsync(id);

            if (StatusReceiptItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StatusReceiptItemDto = Mapper.Map(StatusReceiptItem);

            return OkResult( CustomMessage.DefaultMessage , StatusReceiptItemDto);

        }
    }
}
