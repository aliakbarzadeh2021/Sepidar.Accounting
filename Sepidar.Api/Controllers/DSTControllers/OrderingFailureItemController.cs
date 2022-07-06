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

namespace Sepidar.Api.Controllers.OrderingFailureItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OrderingFailureItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderingFailureItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOrderingFailureItemCommand command)
        {
            command.Validate();

            var OrderingFailureItems = await _unitOfWork.OrderingFailureItemRepository.FindAsync(c => c.Id == command.Id);

            if (OrderingFailureItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOrderingFailureItem = Mapper.Map(command);
            await _unitOfWork.OrderingFailureItemRepository.AddAsync(newOrderingFailureItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOrderingFailureItemCommand command)
        {

            command.Validate();

            var OrderingFailureItem = await _unitOfWork.OrderingFailureItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OrderingFailureItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingFailureItem = Mapper.Map(OrderingFailureItem, command);
            OrderingFailureItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OrderingFailureItem = await _unitOfWork.OrderingFailureItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OrderingFailureItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingFailureItem.IsActive = false;
            OrderingFailureItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OrderingFailureItems = await _unitOfWork.OrderingFailureItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OrderingFailureItemsDto = Mapper.Map(OrderingFailureItems);

            return OkResult(CustomMessage.DefaultMessage, OrderingFailureItemsDto.ToPagingAndSorting(query), OrderingFailureItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OrderingFailureItem = await _unitOfWork.OrderingFailureItemRepository.GetByIdAsync(id);

            if (OrderingFailureItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OrderingFailureItemDto = Mapper.Map(OrderingFailureItem);

            return OkResult( CustomMessage.DefaultMessage , OrderingFailureItemDto);

        }
    }
}
