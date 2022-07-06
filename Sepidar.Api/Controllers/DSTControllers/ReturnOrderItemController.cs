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

namespace Sepidar.Api.Controllers.ReturnOrderItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReturnOrderItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReturnOrderItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReturnOrderItemCommand command)
        {
            command.Validate();

            var ReturnOrderItems = await _unitOfWork.ReturnOrderItemRepository.FindAsync(c => c.Id == command.Id);

            if (ReturnOrderItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReturnOrderItem = Mapper.Map(command);
            await _unitOfWork.ReturnOrderItemRepository.AddAsync(newReturnOrderItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReturnOrderItemCommand command)
        {

            command.Validate();

            var ReturnOrderItem = await _unitOfWork.ReturnOrderItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReturnOrderItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnOrderItem = Mapper.Map(ReturnOrderItem, command);
            ReturnOrderItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReturnOrderItem = await _unitOfWork.ReturnOrderItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReturnOrderItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnOrderItem.IsActive = false;
            ReturnOrderItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReturnOrderItems = await _unitOfWork.ReturnOrderItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReturnOrderItemsDto = Mapper.Map(ReturnOrderItems);

            return OkResult(CustomMessage.DefaultMessage, ReturnOrderItemsDto.ToPagingAndSorting(query), ReturnOrderItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReturnOrderItem = await _unitOfWork.ReturnOrderItemRepository.GetByIdAsync(id);

            if (ReturnOrderItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReturnOrderItemDto = Mapper.Map(ReturnOrderItem);

            return OkResult( CustomMessage.DefaultMessage , ReturnOrderItemDto);

        }
    }
}
