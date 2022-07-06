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

namespace Sepidar.Api.Controllers.BillOfLoadingItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BillOfLoadingItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BillOfLoadingItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBillOfLoadingItemCommand command)
        {
            command.Validate();

            var BillOfLoadingItems = await _unitOfWork.BillOfLoadingItemRepository.FindAsync(c => c.Id == command.Id);

            if (BillOfLoadingItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBillOfLoadingItem = Mapper.Map(command);
            await _unitOfWork.BillOfLoadingItemRepository.AddAsync(newBillOfLoadingItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBillOfLoadingItemCommand command)
        {

            command.Validate();

            var BillOfLoadingItem = await _unitOfWork.BillOfLoadingItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BillOfLoadingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BillOfLoadingItem = Mapper.Map(BillOfLoadingItem, command);
            BillOfLoadingItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BillOfLoadingItem = await _unitOfWork.BillOfLoadingItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BillOfLoadingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BillOfLoadingItem.IsActive = false;
            BillOfLoadingItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BillOfLoadingItems = await _unitOfWork.BillOfLoadingItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BillOfLoadingItemsDto = Mapper.Map(BillOfLoadingItems);

            return OkResult(CustomMessage.DefaultMessage, BillOfLoadingItemsDto.ToPagingAndSorting(query), BillOfLoadingItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BillOfLoadingItem = await _unitOfWork.BillOfLoadingItemRepository.GetByIdAsync(id);

            if (BillOfLoadingItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BillOfLoadingItemDto = Mapper.Map(BillOfLoadingItem);

            return OkResult( CustomMessage.DefaultMessage , BillOfLoadingItemDto);

        }
    }
}
