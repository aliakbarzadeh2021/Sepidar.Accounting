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

namespace Sepidar.Api.Controllers.ReceiptChequeBankingItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReceiptChequeBankingItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReceiptChequeBankingItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReceiptChequeBankingItemCommand command)
        {
            command.Validate();

            var ReceiptChequeBankingItems = await _unitOfWork.ReceiptChequeBankingItemRepository.FindAsync(c => c.Id == command.Id);

            if (ReceiptChequeBankingItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReceiptChequeBankingItem = Mapper.Map(command);
            await _unitOfWork.ReceiptChequeBankingItemRepository.AddAsync(newReceiptChequeBankingItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReceiptChequeBankingItemCommand command)
        {

            command.Validate();

            var ReceiptChequeBankingItem = await _unitOfWork.ReceiptChequeBankingItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReceiptChequeBankingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptChequeBankingItem = Mapper.Map(ReceiptChequeBankingItem, command);
            ReceiptChequeBankingItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReceiptChequeBankingItem = await _unitOfWork.ReceiptChequeBankingItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReceiptChequeBankingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptChequeBankingItem.IsActive = false;
            ReceiptChequeBankingItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReceiptChequeBankingItems = await _unitOfWork.ReceiptChequeBankingItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReceiptChequeBankingItemsDto = Mapper.Map(ReceiptChequeBankingItems);

            return OkResult(CustomMessage.DefaultMessage, ReceiptChequeBankingItemsDto.ToPagingAndSorting(query), ReceiptChequeBankingItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReceiptChequeBankingItem = await _unitOfWork.ReceiptChequeBankingItemRepository.GetByIdAsync(id);

            if (ReceiptChequeBankingItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReceiptChequeBankingItemDto = Mapper.Map(ReceiptChequeBankingItem);

            return OkResult( CustomMessage.DefaultMessage , ReceiptChequeBankingItemDto);

        }
    }
}
