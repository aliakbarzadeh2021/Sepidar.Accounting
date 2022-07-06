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

namespace Sepidar.Api.Controllers.PurchaseCostItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseCostItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PurchaseCostItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPurchaseCostItemCommand command)
        {
            command.Validate();

            var PurchaseCostItems = await _unitOfWork.PurchaseCostItemRepository.FindAsync(c => c.Id == command.Id);

            if (PurchaseCostItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPurchaseCostItem = Mapper.Map(command);
            await _unitOfWork.PurchaseCostItemRepository.AddAsync(newPurchaseCostItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPurchaseCostItemCommand command)
        {

            command.Validate();

            var PurchaseCostItem = await _unitOfWork.PurchaseCostItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PurchaseCostItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseCostItem = Mapper.Map(PurchaseCostItem, command);
            PurchaseCostItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PurchaseCostItem = await _unitOfWork.PurchaseCostItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PurchaseCostItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseCostItem.IsActive = false;
            PurchaseCostItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PurchaseCostItems = await _unitOfWork.PurchaseCostItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PurchaseCostItemsDto = Mapper.Map(PurchaseCostItems);

            return OkResult(CustomMessage.DefaultMessage, PurchaseCostItemsDto.ToPagingAndSorting(query), PurchaseCostItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PurchaseCostItem = await _unitOfWork.PurchaseCostItemRepository.GetByIdAsync(id);

            if (PurchaseCostItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PurchaseCostItemDto = Mapper.Map(PurchaseCostItem);

            return OkResult( CustomMessage.DefaultMessage , PurchaseCostItemDto);

        }
    }
}
