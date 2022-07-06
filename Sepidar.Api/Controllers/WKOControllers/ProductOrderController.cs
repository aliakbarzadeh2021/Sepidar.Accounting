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

namespace Sepidar.Api.Controllers.ProductOrderControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductOrderController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductOrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductOrderCommand command)
        {
            command.Validate();

            var ProductOrders = await _unitOfWork.ProductOrderRepository.FindAsync(c => c.Id == command.Id);

            if (ProductOrders.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProductOrder = Mapper.Map(command);
            await _unitOfWork.ProductOrderRepository.AddAsync(newProductOrder);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductOrderCommand command)
        {

            command.Validate();

            var ProductOrder = await _unitOfWork.ProductOrderRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProductOrder == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductOrder = Mapper.Map(ProductOrder, command);
            ProductOrder.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProductOrder = await _unitOfWork.ProductOrderRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProductOrder == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductOrder.IsActive = false;
            ProductOrder.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProductOrders = await _unitOfWork.ProductOrderRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProductOrdersDto = Mapper.Map(ProductOrders);

            return OkResult(CustomMessage.DefaultMessage, ProductOrdersDto.ToPagingAndSorting(query), ProductOrdersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProductOrder = await _unitOfWork.ProductOrderRepository.GetByIdAsync(id);

            if (ProductOrder is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProductOrderDto = Mapper.Map(ProductOrder);

            return OkResult( CustomMessage.DefaultMessage , ProductOrderDto);

        }
    }
}
