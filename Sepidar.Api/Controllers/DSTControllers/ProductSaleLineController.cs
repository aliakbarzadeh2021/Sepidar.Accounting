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

namespace Sepidar.Api.Controllers.ProductSaleLineControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductSaleLineController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductSaleLineController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductSaleLineCommand command)
        {
            command.Validate();

            var ProductSaleLines = await _unitOfWork.ProductSaleLineRepository.FindAsync(c => c.Id == command.Id);

            if (ProductSaleLines.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProductSaleLine = Mapper.Map(command);
            await _unitOfWork.ProductSaleLineRepository.AddAsync(newProductSaleLine);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductSaleLineCommand command)
        {

            command.Validate();

            var ProductSaleLine = await _unitOfWork.ProductSaleLineRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProductSaleLine == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductSaleLine = Mapper.Map(ProductSaleLine, command);
            ProductSaleLine.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProductSaleLine = await _unitOfWork.ProductSaleLineRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProductSaleLine == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductSaleLine.IsActive = false;
            ProductSaleLine.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProductSaleLines = await _unitOfWork.ProductSaleLineRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProductSaleLinesDto = Mapper.Map(ProductSaleLines);

            return OkResult(CustomMessage.DefaultMessage, ProductSaleLinesDto.ToPagingAndSorting(query), ProductSaleLinesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProductSaleLine = await _unitOfWork.ProductSaleLineRepository.GetByIdAsync(id);

            if (ProductSaleLine is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProductSaleLineDto = Mapper.Map(ProductSaleLine);

            return OkResult( CustomMessage.DefaultMessage , ProductSaleLineDto);

        }
    }
}
