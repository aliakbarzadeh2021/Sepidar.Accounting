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

namespace Sepidar.Api.Controllers.PurchaseOrderControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseOrderController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PurchaseOrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPurchaseOrderCommand command)
        {
            command.Validate();

            var PurchaseOrders = await _unitOfWork.PurchaseOrderRepository.FindAsync(c => c.Id == command.Id);

            if (PurchaseOrders.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPurchaseOrder = Mapper.Map(command);
            await _unitOfWork.PurchaseOrderRepository.AddAsync(newPurchaseOrder);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPurchaseOrderCommand command)
        {

            command.Validate();

            var PurchaseOrder = await _unitOfWork.PurchaseOrderRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PurchaseOrder == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseOrder = Mapper.Map(PurchaseOrder, command);
            PurchaseOrder.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PurchaseOrder = await _unitOfWork.PurchaseOrderRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PurchaseOrder == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PurchaseOrder.IsActive = false;
            PurchaseOrder.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PurchaseOrders = await _unitOfWork.PurchaseOrderRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PurchaseOrdersDto = Mapper.Map(PurchaseOrders);

            return OkResult(CustomMessage.DefaultMessage, PurchaseOrdersDto.ToPagingAndSorting(query), PurchaseOrdersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PurchaseOrder = await _unitOfWork.PurchaseOrderRepository.GetByIdAsync(id);

            if (PurchaseOrder is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PurchaseOrderDto = Mapper.Map(PurchaseOrder);

            return OkResult( CustomMessage.DefaultMessage , PurchaseOrderDto);

        }
    }
}
