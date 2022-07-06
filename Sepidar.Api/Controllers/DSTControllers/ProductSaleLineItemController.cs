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

namespace Sepidar.Api.Controllers.ProductSaleLineItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductSaleLineItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductSaleLineItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductSaleLineItemCommand command)
        {
            command.Validate();

            var ProductSaleLineItems = await _unitOfWork.ProductSaleLineItemRepository.FindAsync(c => c.Id == command.Id);

            if (ProductSaleLineItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProductSaleLineItem = Mapper.Map(command);
            await _unitOfWork.ProductSaleLineItemRepository.AddAsync(newProductSaleLineItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductSaleLineItemCommand command)
        {

            command.Validate();

            var ProductSaleLineItem = await _unitOfWork.ProductSaleLineItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProductSaleLineItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductSaleLineItem = Mapper.Map(ProductSaleLineItem, command);
            ProductSaleLineItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProductSaleLineItem = await _unitOfWork.ProductSaleLineItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProductSaleLineItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductSaleLineItem.IsActive = false;
            ProductSaleLineItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProductSaleLineItems = await _unitOfWork.ProductSaleLineItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProductSaleLineItemsDto = Mapper.Map(ProductSaleLineItems);

            return OkResult(CustomMessage.DefaultMessage, ProductSaleLineItemsDto.ToPagingAndSorting(query), ProductSaleLineItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProductSaleLineItem = await _unitOfWork.ProductSaleLineItemRepository.GetByIdAsync(id);

            if (ProductSaleLineItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProductSaleLineItemDto = Mapper.Map(ProductSaleLineItem);

            return OkResult( CustomMessage.DefaultMessage , ProductSaleLineItemDto);

        }
    }
}
