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

namespace Sepidar.Api.Controllers.OrderingFailureControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OrderingFailureController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderingFailureController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOrderingFailureCommand command)
        {
            command.Validate();

            var OrderingFailures = await _unitOfWork.OrderingFailureRepository.FindAsync(c => c.Id == command.Id);

            if (OrderingFailures.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOrderingFailure = Mapper.Map(command);
            await _unitOfWork.OrderingFailureRepository.AddAsync(newOrderingFailure);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOrderingFailureCommand command)
        {

            command.Validate();

            var OrderingFailure = await _unitOfWork.OrderingFailureRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OrderingFailure == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingFailure = Mapper.Map(OrderingFailure, command);
            OrderingFailure.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OrderingFailure = await _unitOfWork.OrderingFailureRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OrderingFailure == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OrderingFailure.IsActive = false;
            OrderingFailure.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OrderingFailures = await _unitOfWork.OrderingFailureRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OrderingFailuresDto = Mapper.Map(OrderingFailures);

            return OkResult(CustomMessage.DefaultMessage, OrderingFailuresDto.ToPagingAndSorting(query), OrderingFailuresDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OrderingFailure = await _unitOfWork.OrderingFailureRepository.GetByIdAsync(id);

            if (OrderingFailure is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OrderingFailureDto = Mapper.Map(OrderingFailure);

            return OkResult( CustomMessage.DefaultMessage , OrderingFailureDto);

        }
    }
}
