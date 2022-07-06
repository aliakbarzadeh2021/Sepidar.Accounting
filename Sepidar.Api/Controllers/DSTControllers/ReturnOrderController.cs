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

namespace Sepidar.Api.Controllers.ReturnOrderControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReturnOrderController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReturnOrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReturnOrderCommand command)
        {
            command.Validate();

            var ReturnOrders = await _unitOfWork.ReturnOrderRepository.FindAsync(c => c.Id == command.Id);

            if (ReturnOrders.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReturnOrder = Mapper.Map(command);
            await _unitOfWork.ReturnOrderRepository.AddAsync(newReturnOrder);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReturnOrderCommand command)
        {

            command.Validate();

            var ReturnOrder = await _unitOfWork.ReturnOrderRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReturnOrder == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnOrder = Mapper.Map(ReturnOrder, command);
            ReturnOrder.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReturnOrder = await _unitOfWork.ReturnOrderRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReturnOrder == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnOrder.IsActive = false;
            ReturnOrder.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReturnOrders = await _unitOfWork.ReturnOrderRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReturnOrdersDto = Mapper.Map(ReturnOrders);

            return OkResult(CustomMessage.DefaultMessage, ReturnOrdersDto.ToPagingAndSorting(query), ReturnOrdersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReturnOrder = await _unitOfWork.ReturnOrderRepository.GetByIdAsync(id);

            if (ReturnOrder is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReturnOrderDto = Mapper.Map(ReturnOrder);

            return OkResult( CustomMessage.DefaultMessage , ReturnOrderDto);

        }
    }
}
