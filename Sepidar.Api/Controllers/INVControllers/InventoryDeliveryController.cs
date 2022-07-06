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

namespace Sepidar.Api.Controllers.InventoryDeliveryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryDeliveryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryDeliveryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryDeliveryCommand command)
        {
            command.Validate();

            var InventoryDeliverys = await _unitOfWork.InventoryDeliveryRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryDeliverys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryDelivery = Mapper.Map(command);
            await _unitOfWork.InventoryDeliveryRepository.AddAsync(newInventoryDelivery);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryDeliveryCommand command)
        {

            command.Validate();

            var InventoryDelivery = await _unitOfWork.InventoryDeliveryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryDelivery == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryDelivery = Mapper.Map(InventoryDelivery, command);
            InventoryDelivery.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryDelivery = await _unitOfWork.InventoryDeliveryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryDelivery == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryDelivery.IsActive = false;
            InventoryDelivery.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryDeliverys = await _unitOfWork.InventoryDeliveryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryDeliverysDto = Mapper.Map(InventoryDeliverys);

            return OkResult(CustomMessage.DefaultMessage, InventoryDeliverysDto.ToPagingAndSorting(query), InventoryDeliverysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryDelivery = await _unitOfWork.InventoryDeliveryRepository.GetByIdAsync(id);

            if (InventoryDelivery is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryDeliveryDto = Mapper.Map(InventoryDelivery);

            return OkResult( CustomMessage.DefaultMessage , InventoryDeliveryDto);

        }
    }
}
