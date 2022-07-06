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

namespace Sepidar.Api.Controllers.ConfigurationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ConfigurationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddConfigurationCommand command)
        {
            command.Validate();

            var Configurations = await _unitOfWork.ConfigurationRepository.FindAsync(c => c.Id == command.Id);

            if (Configurations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newConfiguration = Mapper.Map(command);
            await _unitOfWork.ConfigurationRepository.AddAsync(newConfiguration);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditConfigurationCommand command)
        {

            command.Validate();

            var Configuration = await _unitOfWork.ConfigurationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Configuration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Configuration = Mapper.Map(Configuration, command);
            Configuration.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Configuration = await _unitOfWork.ConfigurationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Configuration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Configuration.IsActive = false;
            Configuration.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Configurations = await _unitOfWork.ConfigurationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ConfigurationsDto = Mapper.Map(Configurations);

            return OkResult(CustomMessage.DefaultMessage, ConfigurationsDto.ToPagingAndSorting(query), ConfigurationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Configuration = await _unitOfWork.ConfigurationRepository.GetByIdAsync(id);

            if (Configuration is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ConfigurationDto = Mapper.Map(Configuration);

            return OkResult( CustomMessage.DefaultMessage , ConfigurationDto);

        }
    }
}
