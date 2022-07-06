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

namespace Sepidar.Api.Controllers.UserConfigurationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserConfigurationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserConfigurationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserConfigurationCommand command)
        {
            command.Validate();

            var UserConfigurations = await _unitOfWork.UserConfigurationRepository.FindAsync(c => c.Id == command.Id);

            if (UserConfigurations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserConfiguration = Mapper.Map(command);
            await _unitOfWork.UserConfigurationRepository.AddAsync(newUserConfiguration);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserConfigurationCommand command)
        {

            command.Validate();

            var UserConfiguration = await _unitOfWork.UserConfigurationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserConfiguration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserConfiguration = Mapper.Map(UserConfiguration, command);
            UserConfiguration.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserConfiguration = await _unitOfWork.UserConfigurationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserConfiguration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserConfiguration.IsActive = false;
            UserConfiguration.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserConfigurations = await _unitOfWork.UserConfigurationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserConfigurationsDto = Mapper.Map(UserConfigurations);

            return OkResult(CustomMessage.DefaultMessage, UserConfigurationsDto.ToPagingAndSorting(query), UserConfigurationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserConfiguration = await _unitOfWork.UserConfigurationRepository.GetByIdAsync(id);

            if (UserConfiguration is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserConfigurationDto = Mapper.Map(UserConfiguration);

            return OkResult( CustomMessage.DefaultMessage , UserConfigurationDto);

        }
    }
}
