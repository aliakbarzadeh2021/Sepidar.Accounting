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

namespace Sepidar.Api.Controllers.InventoryDeliveryItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryDeliveryItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryDeliveryItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryDeliveryItemCommand command)
        {
            command.Validate();

            var InventoryDeliveryItems = await _unitOfWork.InventoryDeliveryItemRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryDeliveryItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryDeliveryItem = Mapper.Map(command);
            await _unitOfWork.InventoryDeliveryItemRepository.AddAsync(newInventoryDeliveryItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryDeliveryItemCommand command)
        {

            command.Validate();

            var InventoryDeliveryItem = await _unitOfWork.InventoryDeliveryItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryDeliveryItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryDeliveryItem = Mapper.Map(InventoryDeliveryItem, command);
            InventoryDeliveryItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryDeliveryItem = await _unitOfWork.InventoryDeliveryItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryDeliveryItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryDeliveryItem.IsActive = false;
            InventoryDeliveryItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryDeliveryItems = await _unitOfWork.InventoryDeliveryItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryDeliveryItemsDto = Mapper.Map(InventoryDeliveryItems);

            return OkResult(CustomMessage.DefaultMessage, InventoryDeliveryItemsDto.ToPagingAndSorting(query), InventoryDeliveryItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryDeliveryItem = await _unitOfWork.InventoryDeliveryItemRepository.GetByIdAsync(id);

            if (InventoryDeliveryItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryDeliveryItemDto = Mapper.Map(InventoryDeliveryItem);

            return OkResult( CustomMessage.DefaultMessage , InventoryDeliveryItemDto);

        }
    }
}
