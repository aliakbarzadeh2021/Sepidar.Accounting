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

namespace Sepidar.Api.Controllers.InventoryReceiptControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryReceiptController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryReceiptController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryReceiptCommand command)
        {
            command.Validate();

            var InventoryReceipts = await _unitOfWork.InventoryReceiptRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryReceipts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryReceipt = Mapper.Map(command);
            await _unitOfWork.InventoryReceiptRepository.AddAsync(newInventoryReceipt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryReceiptCommand command)
        {

            command.Validate();

            var InventoryReceipt = await _unitOfWork.InventoryReceiptRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryReceipt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryReceipt = Mapper.Map(InventoryReceipt, command);
            InventoryReceipt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryReceipt = await _unitOfWork.InventoryReceiptRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryReceipt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryReceipt.IsActive = false;
            InventoryReceipt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryReceipts = await _unitOfWork.InventoryReceiptRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryReceiptsDto = Mapper.Map(InventoryReceipts);

            return OkResult(CustomMessage.DefaultMessage, InventoryReceiptsDto.ToPagingAndSorting(query), InventoryReceiptsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryReceipt = await _unitOfWork.InventoryReceiptRepository.GetByIdAsync(id);

            if (InventoryReceipt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryReceiptDto = Mapper.Map(InventoryReceipt);

            return OkResult( CustomMessage.DefaultMessage , InventoryReceiptDto);

        }
    }
}
