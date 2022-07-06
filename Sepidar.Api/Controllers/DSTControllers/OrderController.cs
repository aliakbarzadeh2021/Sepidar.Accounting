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

namespace Sepidar.Api.Controllers.OrderControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOrderCommand command)
        {
            command.Validate();

            var Orders = await _unitOfWork.OrderRepository.FindAsync(c => c.Id == command.Id);

            if (Orders.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOrder = Mapper.Map(command);
            await _unitOfWork.OrderRepository.AddAsync(newOrder);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOrderCommand command)
        {

            command.Validate();

            var Order = await _unitOfWork.OrderRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Order == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Order = Mapper.Map(Order, command);
            Order.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Order = await _unitOfWork.OrderRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Order == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Order.IsActive = false;
            Order.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Orders = await _unitOfWork.OrderRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OrdersDto = Mapper.Map(Orders);

            return OkResult(CustomMessage.DefaultMessage, OrdersDto.ToPagingAndSorting(query), OrdersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Order = await _unitOfWork.OrderRepository.GetByIdAsync(id);

            if (Order is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OrderDto = Mapper.Map(Order);

            return OkResult( CustomMessage.DefaultMessage , OrderDto);

        }
    }
}
