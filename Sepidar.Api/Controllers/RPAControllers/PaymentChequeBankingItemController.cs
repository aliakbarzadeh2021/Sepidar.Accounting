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

namespace Sepidar.Api.Controllers.PaymentChequeBankingItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentChequeBankingItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentChequeBankingItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaymentChequeBankingItemCommand command)
        {
            command.Validate();

            var PaymentChequeBankingItems = await _unitOfWork.PaymentChequeBankingItemRepository.FindAsync(c => c.Id == command.Id);

            if (PaymentChequeBankingItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaymentChequeBankingItem = Mapper.Map(command);
            await _unitOfWork.PaymentChequeBankingItemRepository.AddAsync(newPaymentChequeBankingItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaymentChequeBankingItemCommand command)
        {

            command.Validate();

            var PaymentChequeBankingItem = await _unitOfWork.PaymentChequeBankingItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaymentChequeBankingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentChequeBankingItem = Mapper.Map(PaymentChequeBankingItem, command);
            PaymentChequeBankingItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaymentChequeBankingItem = await _unitOfWork.PaymentChequeBankingItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaymentChequeBankingItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaymentChequeBankingItem.IsActive = false;
            PaymentChequeBankingItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaymentChequeBankingItems = await _unitOfWork.PaymentChequeBankingItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaymentChequeBankingItemsDto = Mapper.Map(PaymentChequeBankingItems);

            return OkResult(CustomMessage.DefaultMessage, PaymentChequeBankingItemsDto.ToPagingAndSorting(query), PaymentChequeBankingItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaymentChequeBankingItem = await _unitOfWork.PaymentChequeBankingItemRepository.GetByIdAsync(id);

            if (PaymentChequeBankingItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaymentChequeBankingItemDto = Mapper.Map(PaymentChequeBankingItem);

            return OkResult( CustomMessage.DefaultMessage , PaymentChequeBankingItemDto);

        }
    }
}
