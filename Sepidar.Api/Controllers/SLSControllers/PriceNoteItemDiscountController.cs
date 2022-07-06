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

namespace Sepidar.Api.Controllers.PriceNoteItemDiscountControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PriceNoteItemDiscountController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PriceNoteItemDiscountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPriceNoteItemDiscountCommand command)
        {
            command.Validate();

            var PriceNoteItemDiscounts = await _unitOfWork.PriceNoteItemDiscountRepository.FindAsync(c => c.Id == command.Id);

            if (PriceNoteItemDiscounts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPriceNoteItemDiscount = Mapper.Map(command);
            await _unitOfWork.PriceNoteItemDiscountRepository.AddAsync(newPriceNoteItemDiscount);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPriceNoteItemDiscountCommand command)
        {

            command.Validate();

            var PriceNoteItemDiscount = await _unitOfWork.PriceNoteItemDiscountRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PriceNoteItemDiscount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PriceNoteItemDiscount = Mapper.Map(PriceNoteItemDiscount, command);
            PriceNoteItemDiscount.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PriceNoteItemDiscount = await _unitOfWork.PriceNoteItemDiscountRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PriceNoteItemDiscount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PriceNoteItemDiscount.IsActive = false;
            PriceNoteItemDiscount.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PriceNoteItemDiscounts = await _unitOfWork.PriceNoteItemDiscountRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PriceNoteItemDiscountsDto = Mapper.Map(PriceNoteItemDiscounts);

            return OkResult(CustomMessage.DefaultMessage, PriceNoteItemDiscountsDto.ToPagingAndSorting(query), PriceNoteItemDiscountsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PriceNoteItemDiscount = await _unitOfWork.PriceNoteItemDiscountRepository.GetByIdAsync(id);

            if (PriceNoteItemDiscount is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PriceNoteItemDiscountDto = Mapper.Map(PriceNoteItemDiscount);

            return OkResult( CustomMessage.DefaultMessage , PriceNoteItemDiscountDto);

        }
    }
}
