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

namespace Sepidar.Api.Controllers.ProductPackDiscountControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductPackDiscountController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductPackDiscountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductPackDiscountCommand command)
        {
            command.Validate();

            var ProductPackDiscounts = await _unitOfWork.ProductPackDiscountRepository.FindAsync(c => c.Id == command.Id);

            if (ProductPackDiscounts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProductPackDiscount = Mapper.Map(command);
            await _unitOfWork.ProductPackDiscountRepository.AddAsync(newProductPackDiscount);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductPackDiscountCommand command)
        {

            command.Validate();

            var ProductPackDiscount = await _unitOfWork.ProductPackDiscountRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProductPackDiscount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductPackDiscount = Mapper.Map(ProductPackDiscount, command);
            ProductPackDiscount.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProductPackDiscount = await _unitOfWork.ProductPackDiscountRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProductPackDiscount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductPackDiscount.IsActive = false;
            ProductPackDiscount.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProductPackDiscounts = await _unitOfWork.ProductPackDiscountRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProductPackDiscountsDto = Mapper.Map(ProductPackDiscounts);

            return OkResult(CustomMessage.DefaultMessage, ProductPackDiscountsDto.ToPagingAndSorting(query), ProductPackDiscountsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProductPackDiscount = await _unitOfWork.ProductPackDiscountRepository.GetByIdAsync(id);

            if (ProductPackDiscount is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProductPackDiscountDto = Mapper.Map(ProductPackDiscount);

            return OkResult( CustomMessage.DefaultMessage , ProductPackDiscountDto);

        }
    }
}
