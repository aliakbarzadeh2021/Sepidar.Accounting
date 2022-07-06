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

namespace Sepidar.Api.Controllers.DeviceUserPartyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceUserPartyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeviceUserPartyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDeviceUserPartyCommand command)
        {
            command.Validate();

            var DeviceUserPartys = await _unitOfWork.DeviceUserPartyRepository.FindAsync(c => c.Id == command.Id);

            if (DeviceUserPartys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDeviceUserParty = Mapper.Map(command);
            await _unitOfWork.DeviceUserPartyRepository.AddAsync(newDeviceUserParty);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDeviceUserPartyCommand command)
        {

            command.Validate();

            var DeviceUserParty = await _unitOfWork.DeviceUserPartyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DeviceUserParty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DeviceUserParty = Mapper.Map(DeviceUserParty, command);
            DeviceUserParty.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DeviceUserParty = await _unitOfWork.DeviceUserPartyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DeviceUserParty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DeviceUserParty.IsActive = false;
            DeviceUserParty.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DeviceUserPartys = await _unitOfWork.DeviceUserPartyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DeviceUserPartysDto = Mapper.Map(DeviceUserPartys);

            return OkResult(CustomMessage.DefaultMessage, DeviceUserPartysDto.ToPagingAndSorting(query), DeviceUserPartysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DeviceUserParty = await _unitOfWork.DeviceUserPartyRepository.GetByIdAsync(id);

            if (DeviceUserParty is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DeviceUserPartyDto = Mapper.Map(DeviceUserParty);

            return OkResult( CustomMessage.DefaultMessage , DeviceUserPartyDto);

        }
    }
}
