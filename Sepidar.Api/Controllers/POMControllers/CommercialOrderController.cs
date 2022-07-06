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

namespace Sepidar.Api.Controllers.CommercialOrderControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommercialOrderController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommercialOrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommercialOrderCommand command)
        {
            command.Validate();

            var CommercialOrders = await _unitOfWork.CommercialOrderRepository.FindAsync(c => c.Id == command.Id);

            if (CommercialOrders.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommercialOrder = Mapper.Map(command);
            await _unitOfWork.CommercialOrderRepository.AddAsync(newCommercialOrder);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommercialOrderCommand command)
        {

            command.Validate();

            var CommercialOrder = await _unitOfWork.CommercialOrderRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommercialOrder == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommercialOrder = Mapper.Map(CommercialOrder, command);
            CommercialOrder.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommercialOrder = await _unitOfWork.CommercialOrderRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommercialOrder == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommercialOrder.IsActive = false;
            CommercialOrder.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommercialOrders = await _unitOfWork.CommercialOrderRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommercialOrdersDto = Mapper.Map(CommercialOrders);

            return OkResult(CustomMessage.DefaultMessage, CommercialOrdersDto.ToPagingAndSorting(query), CommercialOrdersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommercialOrder = await _unitOfWork.CommercialOrderRepository.GetByIdAsync(id);

            if (CommercialOrder is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommercialOrderDto = Mapper.Map(CommercialOrder);

            return OkResult( CustomMessage.DefaultMessage , CommercialOrderDto);

        }
    }
}
