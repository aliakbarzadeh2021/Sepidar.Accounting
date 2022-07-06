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

namespace Sepidar.Api.Controllers.PurchaseOtherCostItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseOtherCostItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PurchaseOtherCostItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPurchaseOtherCostItemCommand command)
        {
            command.Validate();

            var PurchaseOtherCostItems = await _unitOfWork.PurchaseOtherCostItemRepository.FindAsync(c => c.Id == command.Id);

            if (PurchaseOtherCostItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPurchaseOtherCostItem = Mapper.Map(command);
            await _unitOfWork.PurchaseOtherCostItemRepository.AddAsync(newPurchaseOtherCostItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPurchaseOtherCostItemCommand command)
        {

            command.Validate();

            var PurchaseOtherCostItem = await _unitOfWork.PurchaseOtherCostItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PurchaseOtherCostItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseOtherCostItem = Mapper.Map(PurchaseOtherCostItem, command);
            PurchaseOtherCostItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PurchaseOtherCostItem = await _unitOfWork.PurchaseOtherCostItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PurchaseOtherCostItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseOtherCostItem.IsActive = false;
            PurchaseOtherCostItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PurchaseOtherCostItems = await _unitOfWork.PurchaseOtherCostItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PurchaseOtherCostItemsDto = Mapper.Map(PurchaseOtherCostItems);

            return OkResult(CustomMessage.DefaultMessage, PurchaseOtherCostItemsDto.ToPagingAndSorting(query), PurchaseOtherCostItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PurchaseOtherCostItem = await _unitOfWork.PurchaseOtherCostItemRepository.GetByIdAsync(id);

            if (PurchaseOtherCostItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PurchaseOtherCostItemDto = Mapper.Map(PurchaseOtherCostItem);

            return OkResult( CustomMessage.DefaultMessage , PurchaseOtherCostItemDto);

        }
    }
}
