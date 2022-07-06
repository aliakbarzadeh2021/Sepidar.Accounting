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

namespace Sepidar.Api.Controllers.DiscountControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DiscountController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DiscountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDiscountCommand command)
        {
            command.Validate();

            var Discounts = await _unitOfWork.DiscountRepository.FindAsync(c => c.Id == command.Id);

            if (Discounts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDiscount = Mapper.Map(command);
            await _unitOfWork.DiscountRepository.AddAsync(newDiscount);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDiscountCommand command)
        {

            command.Validate();

            var Discount = await _unitOfWork.DiscountRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Discount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Discount = Mapper.Map(Discount, command);
            Discount.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Discount = await _unitOfWork.DiscountRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Discount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Discount.IsActive = false;
            Discount.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Discounts = await _unitOfWork.DiscountRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DiscountsDto = Mapper.Map(Discounts);

            return OkResult(CustomMessage.DefaultMessage, DiscountsDto.ToPagingAndSorting(query), DiscountsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Discount = await _unitOfWork.DiscountRepository.GetByIdAsync(id);

            if (Discount is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DiscountDto = Mapper.Map(Discount);

            return OkResult( CustomMessage.DefaultMessage , DiscountDto);

        }
    }
}
