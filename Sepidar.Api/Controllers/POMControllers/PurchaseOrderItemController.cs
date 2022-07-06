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

namespace Sepidar.Api.Controllers.PurchaseOrderItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseOrderItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PurchaseOrderItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPurchaseOrderItemCommand command)
        {
            command.Validate();

            var PurchaseOrderItems = await _unitOfWork.PurchaseOrderItemRepository.FindAsync(c => c.Id == command.Id);

            if (PurchaseOrderItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPurchaseOrderItem = Mapper.Map(command);
            await _unitOfWork.PurchaseOrderItemRepository.AddAsync(newPurchaseOrderItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPurchaseOrderItemCommand command)
        {

            command.Validate();

            var PurchaseOrderItem = await _unitOfWork.PurchaseOrderItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PurchaseOrderItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseOrderItem = Mapper.Map(PurchaseOrderItem, command);
            PurchaseOrderItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PurchaseOrderItem = await _unitOfWork.PurchaseOrderItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PurchaseOrderItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseOrderItem.IsActive = false;
            PurchaseOrderItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PurchaseOrderItems = await _unitOfWork.PurchaseOrderItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PurchaseOrderItemsDto = Mapper.Map(PurchaseOrderItems);

            return OkResult(CustomMessage.DefaultMessage, PurchaseOrderItemsDto.ToPagingAndSorting(query), PurchaseOrderItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PurchaseOrderItem = await _unitOfWork.PurchaseOrderItemRepository.GetByIdAsync(id);

            if (PurchaseOrderItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PurchaseOrderItemDto = Mapper.Map(PurchaseOrderItem);

            return OkResult( CustomMessage.DefaultMessage , PurchaseOrderItemDto);

        }
    }
}
