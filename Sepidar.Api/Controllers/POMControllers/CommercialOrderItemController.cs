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

namespace Sepidar.Api.Controllers.CommercialOrderItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommercialOrderItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommercialOrderItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommercialOrderItemCommand command)
        {
            command.Validate();

            var CommercialOrderItems = await _unitOfWork.CommercialOrderItemRepository.FindAsync(c => c.Id == command.Id);

            if (CommercialOrderItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommercialOrderItem = Mapper.Map(command);
            await _unitOfWork.CommercialOrderItemRepository.AddAsync(newCommercialOrderItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommercialOrderItemCommand command)
        {

            command.Validate();

            var CommercialOrderItem = await _unitOfWork.CommercialOrderItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommercialOrderItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommercialOrderItem = Mapper.Map(CommercialOrderItem, command);
            CommercialOrderItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommercialOrderItem = await _unitOfWork.CommercialOrderItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommercialOrderItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommercialOrderItem.IsActive = false;
            CommercialOrderItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommercialOrderItems = await _unitOfWork.CommercialOrderItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommercialOrderItemsDto = Mapper.Map(CommercialOrderItems);

            return OkResult(CustomMessage.DefaultMessage, CommercialOrderItemsDto.ToPagingAndSorting(query), CommercialOrderItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommercialOrderItem = await _unitOfWork.CommercialOrderItemRepository.GetByIdAsync(id);

            if (CommercialOrderItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommercialOrderItemDto = Mapper.Map(CommercialOrderItem);

            return OkResult( CustomMessage.DefaultMessage , CommercialOrderItemDto);

        }
    }
}
