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

namespace Sepidar.Api.Controllers.PaySettlementItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaySettlementItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaySettlementItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaySettlementItemCommand command)
        {
            command.Validate();

            var PaySettlementItems = await _unitOfWork.PaySettlementItemRepository.FindAsync(c => c.Id == command.Id);

            if (PaySettlementItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaySettlementItem = Mapper.Map(command);
            await _unitOfWork.PaySettlementItemRepository.AddAsync(newPaySettlementItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaySettlementItemCommand command)
        {

            command.Validate();

            var PaySettlementItem = await _unitOfWork.PaySettlementItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaySettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaySettlementItem = Mapper.Map(PaySettlementItem, command);
            PaySettlementItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaySettlementItem = await _unitOfWork.PaySettlementItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaySettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaySettlementItem.IsActive = false;
            PaySettlementItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaySettlementItems = await _unitOfWork.PaySettlementItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaySettlementItemsDto = Mapper.Map(PaySettlementItems);

            return OkResult(CustomMessage.DefaultMessage, PaySettlementItemsDto.ToPagingAndSorting(query), PaySettlementItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaySettlementItem = await _unitOfWork.PaySettlementItemRepository.GetByIdAsync(id);

            if (PaySettlementItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaySettlementItemDto = Mapper.Map(PaySettlementItem);

            return OkResult( CustomMessage.DefaultMessage , PaySettlementItemDto);

        }
    }
}
