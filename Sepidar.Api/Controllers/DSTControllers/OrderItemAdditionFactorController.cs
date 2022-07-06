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

namespace Sepidar.Api.Controllers.OrderItemAdditionFactorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemAdditionFactorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderItemAdditionFactorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOrderItemAdditionFactorCommand command)
        {
            command.Validate();

            var OrderItemAdditionFactors = await _unitOfWork.OrderItemAdditionFactorRepository.FindAsync(c => c.Id == command.Id);

            if (OrderItemAdditionFactors.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOrderItemAdditionFactor = Mapper.Map(command);
            await _unitOfWork.OrderItemAdditionFactorRepository.AddAsync(newOrderItemAdditionFactor);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOrderItemAdditionFactorCommand command)
        {

            command.Validate();

            var OrderItemAdditionFactor = await _unitOfWork.OrderItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OrderItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderItemAdditionFactor = Mapper.Map(OrderItemAdditionFactor, command);
            OrderItemAdditionFactor.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OrderItemAdditionFactor = await _unitOfWork.OrderItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OrderItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderItemAdditionFactor.IsActive = false;
            OrderItemAdditionFactor.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OrderItemAdditionFactors = await _unitOfWork.OrderItemAdditionFactorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OrderItemAdditionFactorsDto = Mapper.Map(OrderItemAdditionFactors);

            return OkResult(CustomMessage.DefaultMessage, OrderItemAdditionFactorsDto.ToPagingAndSorting(query), OrderItemAdditionFactorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OrderItemAdditionFactor = await _unitOfWork.OrderItemAdditionFactorRepository.GetByIdAsync(id);

            if (OrderItemAdditionFactor is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OrderItemAdditionFactorDto = Mapper.Map(OrderItemAdditionFactor);

            return OkResult( CustomMessage.DefaultMessage , OrderItemAdditionFactorDto);

        }
    }
}
