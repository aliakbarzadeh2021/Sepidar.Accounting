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

namespace Sepidar.Api.Controllers.InventoryBalancingItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryBalancingItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryBalancingItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryBalancingItemCommand command)
        {
            command.Validate();

            var InventoryBalancingItems = await _unitOfWork.InventoryBalancingItemRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryBalancingItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryBalancingItem = Mapper.Map(command);
            await _unitOfWork.InventoryBalancingItemRepository.AddAsync(newInventoryBalancingItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryBalancingItemCommand command)
        {

            command.Validate();

            var InventoryBalancingItem = await _unitOfWork.InventoryBalancingItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryBalancingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryBalancingItem = Mapper.Map(InventoryBalancingItem, command);
            InventoryBalancingItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryBalancingItem = await _unitOfWork.InventoryBalancingItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryBalancingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryBalancingItem.IsActive = false;
            InventoryBalancingItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryBalancingItems = await _unitOfWork.InventoryBalancingItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryBalancingItemsDto = Mapper.Map(InventoryBalancingItems);

            return OkResult(CustomMessage.DefaultMessage, InventoryBalancingItemsDto.ToPagingAndSorting(query), InventoryBalancingItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryBalancingItem = await _unitOfWork.InventoryBalancingItemRepository.GetByIdAsync(id);

            if (InventoryBalancingItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryBalancingItemDto = Mapper.Map(InventoryBalancingItem);

            return OkResult( CustomMessage.DefaultMessage , InventoryBalancingItemDto);

        }
    }
}
