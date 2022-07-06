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

namespace Sepidar.Api.Controllers.OrderItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOrderItemCommand command)
        {
            command.Validate();

            var OrderItems = await _unitOfWork.OrderItemRepository.FindAsync(c => c.Id == command.Id);

            if (OrderItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOrderItem = Mapper.Map(command);
            await _unitOfWork.OrderItemRepository.AddAsync(newOrderItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOrderItemCommand command)
        {

            command.Validate();

            var OrderItem = await _unitOfWork.OrderItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OrderItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderItem = Mapper.Map(OrderItem, command);
            OrderItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OrderItem = await _unitOfWork.OrderItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OrderItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderItem.IsActive = false;
            OrderItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OrderItems = await _unitOfWork.OrderItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OrderItemsDto = Mapper.Map(OrderItems);

            return OkResult(CustomMessage.DefaultMessage, OrderItemsDto.ToPagingAndSorting(query), OrderItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OrderItem = await _unitOfWork.OrderItemRepository.GetByIdAsync(id);

            if (OrderItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OrderItemDto = Mapper.Map(OrderItem);

            return OkResult( CustomMessage.DefaultMessage , OrderItemDto);

        }
    }
}
