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

namespace Sepidar.Api.Controllers.InventoryReceiptItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryReceiptItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryReceiptItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryReceiptItemCommand command)
        {
            command.Validate();

            var InventoryReceiptItems = await _unitOfWork.InventoryReceiptItemRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryReceiptItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryReceiptItem = Mapper.Map(command);
            await _unitOfWork.InventoryReceiptItemRepository.AddAsync(newInventoryReceiptItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryReceiptItemCommand command)
        {

            command.Validate();

            var InventoryReceiptItem = await _unitOfWork.InventoryReceiptItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryReceiptItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryReceiptItem = Mapper.Map(InventoryReceiptItem, command);
            InventoryReceiptItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryReceiptItem = await _unitOfWork.InventoryReceiptItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryReceiptItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryReceiptItem.IsActive = false;
            InventoryReceiptItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryReceiptItems = await _unitOfWork.InventoryReceiptItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryReceiptItemsDto = Mapper.Map(InventoryReceiptItems);

            return OkResult(CustomMessage.DefaultMessage, InventoryReceiptItemsDto.ToPagingAndSorting(query), InventoryReceiptItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryReceiptItem = await _unitOfWork.InventoryReceiptItemRepository.GetByIdAsync(id);

            if (InventoryReceiptItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryReceiptItemDto = Mapper.Map(InventoryReceiptItem);

            return OkResult( CustomMessage.DefaultMessage , InventoryReceiptItemDto);

        }
    }
}
