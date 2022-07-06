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

namespace Sepidar.Api.Controllers.RefundChequeItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class RefundChequeItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RefundChequeItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddRefundChequeItemCommand command)
        {
            command.Validate();

            var RefundChequeItems = await _unitOfWork.RefundChequeItemRepository.FindAsync(c => c.Id == command.Id);

            if (RefundChequeItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newRefundChequeItem = Mapper.Map(command);
            await _unitOfWork.RefundChequeItemRepository.AddAsync(newRefundChequeItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditRefundChequeItemCommand command)
        {

            command.Validate();

            var RefundChequeItem = await _unitOfWork.RefundChequeItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (RefundChequeItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            RefundChequeItem = Mapper.Map(RefundChequeItem, command);
            RefundChequeItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var RefundChequeItem = await _unitOfWork.RefundChequeItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (RefundChequeItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            RefundChequeItem.IsActive = false;
            RefundChequeItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var RefundChequeItems = await _unitOfWork.RefundChequeItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var RefundChequeItemsDto = Mapper.Map(RefundChequeItems);

            return OkResult(CustomMessage.DefaultMessage, RefundChequeItemsDto.ToPagingAndSorting(query), RefundChequeItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var RefundChequeItem = await _unitOfWork.RefundChequeItemRepository.GetByIdAsync(id);

            if (RefundChequeItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var RefundChequeItemDto = Mapper.Map(RefundChequeItem);

            return OkResult( CustomMessage.DefaultMessage , RefundChequeItemDto);

        }
    }
}
