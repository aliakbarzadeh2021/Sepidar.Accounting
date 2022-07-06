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

namespace Sepidar.Api.Controllers.ProductPackItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductPackItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductPackItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductPackItemCommand command)
        {
            command.Validate();

            var ProductPackItems = await _unitOfWork.ProductPackItemRepository.FindAsync(c => c.Id == command.Id);

            if (ProductPackItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProductPackItem = Mapper.Map(command);
            await _unitOfWork.ProductPackItemRepository.AddAsync(newProductPackItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductPackItemCommand command)
        {

            command.Validate();

            var ProductPackItem = await _unitOfWork.ProductPackItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProductPackItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductPackItem = Mapper.Map(ProductPackItem, command);
            ProductPackItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProductPackItem = await _unitOfWork.ProductPackItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProductPackItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductPackItem.IsActive = false;
            ProductPackItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProductPackItems = await _unitOfWork.ProductPackItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProductPackItemsDto = Mapper.Map(ProductPackItems);

            return OkResult(CustomMessage.DefaultMessage, ProductPackItemsDto.ToPagingAndSorting(query), ProductPackItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProductPackItem = await _unitOfWork.ProductPackItemRepository.GetByIdAsync(id);

            if (ProductPackItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProductPackItemDto = Mapper.Map(ProductPackItem);

            return OkResult( CustomMessage.DefaultMessage , ProductPackItemDto);

        }
    }
}
