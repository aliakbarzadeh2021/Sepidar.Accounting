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

namespace Sepidar.Api.Controllers.LocationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public LocationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddLocationCommand command)
        {
            command.Validate();

            var Locations = await _unitOfWork.LocationRepository.FindAsync(c => c.Id == command.Id);

            if (Locations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newLocation = Mapper.Map(command);
            await _unitOfWork.LocationRepository.AddAsync(newLocation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditLocationCommand command)
        {

            command.Validate();

            var Location = await _unitOfWork.LocationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Location == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Location = Mapper.Map(Location, command);
            Location.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Location = await _unitOfWork.LocationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Location == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Location.IsActive = false;
            Location.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Locations = await _unitOfWork.LocationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var LocationsDto = Mapper.Map(Locations);

            return OkResult(CustomMessage.DefaultMessage, LocationsDto.ToPagingAndSorting(query), LocationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Location = await _unitOfWork.LocationRepository.GetByIdAsync(id);

            if (Location is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var LocationDto = Mapper.Map(Location);

            return OkResult( CustomMessage.DefaultMessage , LocationDto);

        }
    }
}
