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

namespace Sepidar.Api.Controllers.BankBillItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BankBillItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BankBillItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBankBillItemCommand command)
        {
            command.Validate();

            var BankBillItems = await _unitOfWork.BankBillItemRepository.FindAsync(c => c.Id == command.Id);

            if (BankBillItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBankBillItem = Mapper.Map(command);
            await _unitOfWork.BankBillItemRepository.AddAsync(newBankBillItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBankBillItemCommand command)
        {

            command.Validate();

            var BankBillItem = await _unitOfWork.BankBillItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BankBillItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankBillItem = Mapper.Map(BankBillItem, command);
            BankBillItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BankBillItem = await _unitOfWork.BankBillItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BankBillItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankBillItem.IsActive = false;
            BankBillItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BankBillItems = await _unitOfWork.BankBillItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BankBillItemsDto = Mapper.Map(BankBillItems);

            return OkResult(CustomMessage.DefaultMessage, BankBillItemsDto.ToPagingAndSorting(query), BankBillItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BankBillItem = await _unitOfWork.BankBillItemRepository.GetByIdAsync(id);

            if (BankBillItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BankBillItemDto = Mapper.Map(BankBillItem);

            return OkResult( CustomMessage.DefaultMessage , BankBillItemDto);

        }
    }
}
