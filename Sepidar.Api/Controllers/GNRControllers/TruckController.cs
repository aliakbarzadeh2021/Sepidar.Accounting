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

namespace Sepidar.Api.Controllers.TruckControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TruckController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TruckController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTruckCommand command)
        {
            command.Validate();

            var Trucks = await _unitOfWork.TruckRepository.FindAsync(c => c.Id == command.Id);

            if (Trucks.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTruck = Mapper.Map(command);
            await _unitOfWork.TruckRepository.AddAsync(newTruck);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTruckCommand command)
        {

            command.Validate();

            var Truck = await _unitOfWork.TruckRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Truck == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Truck = Mapper.Map(Truck, command);
            Truck.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Truck = await _unitOfWork.TruckRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Truck == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Truck.IsActive = false;
            Truck.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Trucks = await _unitOfWork.TruckRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TrucksDto = Mapper.Map(Trucks);

            return OkResult(CustomMessage.DefaultMessage, TrucksDto.ToPagingAndSorting(query), TrucksDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Truck = await _unitOfWork.TruckRepository.GetByIdAsync(id);

            if (Truck is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TruckDto = Mapper.Map(Truck);

            return OkResult( CustomMessage.DefaultMessage , TruckDto);

        }
    }
}
