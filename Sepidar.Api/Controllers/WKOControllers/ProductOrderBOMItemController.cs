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

namespace Sepidar.Api.Controllers.ProductOrderBOMItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductOrderBOMItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductOrderBOMItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductOrderBOMItemCommand command)
        {
            command.Validate();

            var ProductOrderBOMItems = await _unitOfWork.ProductOrderBOMItemRepository.FindAsync(c => c.Id == command.Id);

            if (ProductOrderBOMItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProductOrderBOMItem = Mapper.Map(command);
            await _unitOfWork.ProductOrderBOMItemRepository.AddAsync(newProductOrderBOMItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductOrderBOMItemCommand command)
        {

            command.Validate();

            var ProductOrderBOMItem = await _unitOfWork.ProductOrderBOMItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProductOrderBOMItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductOrderBOMItem = Mapper.Map(ProductOrderBOMItem, command);
            ProductOrderBOMItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProductOrderBOMItem = await _unitOfWork.ProductOrderBOMItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProductOrderBOMItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductOrderBOMItem.IsActive = false;
            ProductOrderBOMItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProductOrderBOMItems = await _unitOfWork.ProductOrderBOMItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProductOrderBOMItemsDto = Mapper.Map(ProductOrderBOMItems);

            return OkResult(CustomMessage.DefaultMessage, ProductOrderBOMItemsDto.ToPagingAndSorting(query), ProductOrderBOMItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProductOrderBOMItem = await _unitOfWork.ProductOrderBOMItemRepository.GetByIdAsync(id);

            if (ProductOrderBOMItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProductOrderBOMItemDto = Mapper.Map(ProductOrderBOMItem);

            return OkResult( CustomMessage.DefaultMessage , ProductOrderBOMItemDto);

        }
    }
}
