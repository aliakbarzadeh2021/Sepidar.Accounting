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

namespace Sepidar.Api.Controllers.DeliveryLocationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryLocationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeliveryLocationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDeliveryLocationCommand command)
        {
            command.Validate();

            var DeliveryLocations = await _unitOfWork.DeliveryLocationRepository.FindAsync(c => c.Id == command.Id);

            if (DeliveryLocations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDeliveryLocation = Mapper.Map(command);
            await _unitOfWork.DeliveryLocationRepository.AddAsync(newDeliveryLocation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDeliveryLocationCommand command)
        {

            command.Validate();

            var DeliveryLocation = await _unitOfWork.DeliveryLocationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DeliveryLocation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DeliveryLocation = Mapper.Map(DeliveryLocation, command);
            DeliveryLocation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DeliveryLocation = await _unitOfWork.DeliveryLocationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DeliveryLocation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DeliveryLocation.IsActive = false;
            DeliveryLocation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DeliveryLocations = await _unitOfWork.DeliveryLocationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DeliveryLocationsDto = Mapper.Map(DeliveryLocations);

            return OkResult(CustomMessage.DefaultMessage, DeliveryLocationsDto.ToPagingAndSorting(query), DeliveryLocationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DeliveryLocation = await _unitOfWork.DeliveryLocationRepository.GetByIdAsync(id);

            if (DeliveryLocation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DeliveryLocationDto = Mapper.Map(DeliveryLocation);

            return OkResult( CustomMessage.DefaultMessage , DeliveryLocationDto);

        }
    }
}
