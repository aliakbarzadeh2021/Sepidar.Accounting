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

namespace Sepidar.Api.Controllers.ItemDiscountControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ItemDiscountController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemDiscountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddItemDiscountCommand command)
        {
            command.Validate();

            var ItemDiscounts = await _unitOfWork.ItemDiscountRepository.FindAsync(c => c.Id == command.Id);

            if (ItemDiscounts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newItemDiscount = Mapper.Map(command);
            await _unitOfWork.ItemDiscountRepository.AddAsync(newItemDiscount);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditItemDiscountCommand command)
        {

            command.Validate();

            var ItemDiscount = await _unitOfWork.ItemDiscountRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ItemDiscount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemDiscount = Mapper.Map(ItemDiscount, command);
            ItemDiscount.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ItemDiscount = await _unitOfWork.ItemDiscountRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ItemDiscount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemDiscount.IsActive = false;
            ItemDiscount.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ItemDiscounts = await _unitOfWork.ItemDiscountRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ItemDiscountsDto = Mapper.Map(ItemDiscounts);

            return OkResult(CustomMessage.DefaultMessage, ItemDiscountsDto.ToPagingAndSorting(query), ItemDiscountsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ItemDiscount = await _unitOfWork.ItemDiscountRepository.GetByIdAsync(id);

            if (ItemDiscount is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ItemDiscountDto = Mapper.Map(ItemDiscount);

            return OkResult( CustomMessage.DefaultMessage , ItemDiscountDto);

        }
    }
}
