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

namespace Sepidar.Api.Controllers.HotDistributionInventoryDeliveryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HotDistributionInventoryDeliveryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HotDistributionInventoryDeliveryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHotDistributionInventoryDeliveryCommand command)
        {
            command.Validate();

            var HotDistributionInventoryDeliverys = await _unitOfWork.HotDistributionInventoryDeliveryRepository.FindAsync(c => c.Id == command.Id);

            if (HotDistributionInventoryDeliverys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHotDistributionInventoryDelivery = Mapper.Map(command);
            await _unitOfWork.HotDistributionInventoryDeliveryRepository.AddAsync(newHotDistributionInventoryDelivery);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHotDistributionInventoryDeliveryCommand command)
        {

            command.Validate();

            var HotDistributionInventoryDelivery = await _unitOfWork.HotDistributionInventoryDeliveryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HotDistributionInventoryDelivery == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionInventoryDelivery = Mapper.Map(HotDistributionInventoryDelivery, command);
            HotDistributionInventoryDelivery.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HotDistributionInventoryDelivery = await _unitOfWork.HotDistributionInventoryDeliveryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HotDistributionInventoryDelivery == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionInventoryDelivery.IsActive = false;
            HotDistributionInventoryDelivery.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HotDistributionInventoryDeliverys = await _unitOfWork.HotDistributionInventoryDeliveryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HotDistributionInventoryDeliverysDto = Mapper.Map(HotDistributionInventoryDeliverys);

            return OkResult(CustomMessage.DefaultMessage, HotDistributionInventoryDeliverysDto.ToPagingAndSorting(query), HotDistributionInventoryDeliverysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HotDistributionInventoryDelivery = await _unitOfWork.HotDistributionInventoryDeliveryRepository.GetByIdAsync(id);

            if (HotDistributionInventoryDelivery is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HotDistributionInventoryDeliveryDto = Mapper.Map(HotDistributionInventoryDelivery);

            return OkResult( CustomMessage.DefaultMessage , HotDistributionInventoryDeliveryDto);

        }
    }
}
