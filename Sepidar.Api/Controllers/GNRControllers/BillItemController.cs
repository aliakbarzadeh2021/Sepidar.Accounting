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

namespace Sepidar.Api.Controllers.BillItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BillItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BillItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBillItemCommand command)
        {
            command.Validate();

            var BillItems = await _unitOfWork.BillItemRepository.FindAsync(c => c.Id == command.Id);

            if (BillItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBillItem = Mapper.Map(command);
            await _unitOfWork.BillItemRepository.AddAsync(newBillItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBillItemCommand command)
        {

            command.Validate();

            var BillItem = await _unitOfWork.BillItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BillItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BillItem = Mapper.Map(BillItem, command);
            BillItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BillItem = await _unitOfWork.BillItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BillItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BillItem.IsActive = false;
            BillItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BillItems = await _unitOfWork.BillItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BillItemsDto = Mapper.Map(BillItems);

            return OkResult(CustomMessage.DefaultMessage, BillItemsDto.ToPagingAndSorting(query), BillItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BillItem = await _unitOfWork.BillItemRepository.GetByIdAsync(id);

            if (BillItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BillItemDto = Mapper.Map(BillItem);

            return OkResult( CustomMessage.DefaultMessage , BillItemDto);

        }
    }
}
