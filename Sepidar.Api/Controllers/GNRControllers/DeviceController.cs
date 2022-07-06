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

namespace Sepidar.Api.Controllers.DeviceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeviceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDeviceCommand command)
        {
            command.Validate();

            var Devices = await _unitOfWork.DeviceRepository.FindAsync(c => c.Id == command.Id);

            if (Devices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDevice = Mapper.Map(command);
            await _unitOfWork.DeviceRepository.AddAsync(newDevice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDeviceCommand command)
        {

            command.Validate();

            var Device = await _unitOfWork.DeviceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Device == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Device = Mapper.Map(Device, command);
            Device.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Device = await _unitOfWork.DeviceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Device == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Device.IsActive = false;
            Device.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Devices = await _unitOfWork.DeviceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DevicesDto = Mapper.Map(Devices);

            return OkResult(CustomMessage.DefaultMessage, DevicesDto.ToPagingAndSorting(query), DevicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Device = await _unitOfWork.DeviceRepository.GetByIdAsync(id);

            if (Device is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DeviceDto = Mapper.Map(Device);

            return OkResult( CustomMessage.DefaultMessage , DeviceDto);

        }
    }
}
