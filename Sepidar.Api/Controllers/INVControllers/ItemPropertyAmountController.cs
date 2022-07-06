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

namespace Sepidar.Api.Controllers.ItemPropertyAmountControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ItemPropertyAmountController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemPropertyAmountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddItemPropertyAmountCommand command)
        {
            command.Validate();

            var ItemPropertyAmounts = await _unitOfWork.ItemPropertyAmountRepository.FindAsync(c => c.Id == command.Id);

            if (ItemPropertyAmounts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newItemPropertyAmount = Mapper.Map(command);
            await _unitOfWork.ItemPropertyAmountRepository.AddAsync(newItemPropertyAmount);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditItemPropertyAmountCommand command)
        {

            command.Validate();

            var ItemPropertyAmount = await _unitOfWork.ItemPropertyAmountRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ItemPropertyAmount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemPropertyAmount = Mapper.Map(ItemPropertyAmount, command);
            ItemPropertyAmount.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ItemPropertyAmount = await _unitOfWork.ItemPropertyAmountRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ItemPropertyAmount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemPropertyAmount.IsActive = false;
            ItemPropertyAmount.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ItemPropertyAmounts = await _unitOfWork.ItemPropertyAmountRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ItemPropertyAmountsDto = Mapper.Map(ItemPropertyAmounts);

            return OkResult(CustomMessage.DefaultMessage, ItemPropertyAmountsDto.ToPagingAndSorting(query), ItemPropertyAmountsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ItemPropertyAmount = await _unitOfWork.ItemPropertyAmountRepository.GetByIdAsync(id);

            if (ItemPropertyAmount is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ItemPropertyAmountDto = Mapper.Map(ItemPropertyAmount);

            return OkResult( CustomMessage.DefaultMessage , ItemPropertyAmountDto);

        }
    }
}
