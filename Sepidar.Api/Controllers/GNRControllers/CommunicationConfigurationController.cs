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

namespace Sepidar.Api.Controllers.CommunicationConfigurationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommunicationConfigurationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommunicationConfigurationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommunicationConfigurationCommand command)
        {
            command.Validate();

            var CommunicationConfigurations = await _unitOfWork.CommunicationConfigurationRepository.FindAsync(c => c.Id == command.Id);

            if (CommunicationConfigurations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommunicationConfiguration = Mapper.Map(command);
            await _unitOfWork.CommunicationConfigurationRepository.AddAsync(newCommunicationConfiguration);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommunicationConfigurationCommand command)
        {

            command.Validate();

            var CommunicationConfiguration = await _unitOfWork.CommunicationConfigurationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommunicationConfiguration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommunicationConfiguration = Mapper.Map(CommunicationConfiguration, command);
            CommunicationConfiguration.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommunicationConfiguration = await _unitOfWork.CommunicationConfigurationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommunicationConfiguration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommunicationConfiguration.IsActive = false;
            CommunicationConfiguration.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommunicationConfigurations = await _unitOfWork.CommunicationConfigurationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommunicationConfigurationsDto = Mapper.Map(CommunicationConfigurations);

            return OkResult(CustomMessage.DefaultMessage, CommunicationConfigurationsDto.ToPagingAndSorting(query), CommunicationConfigurationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommunicationConfiguration = await _unitOfWork.CommunicationConfigurationRepository.GetByIdAsync(id);

            if (CommunicationConfiguration is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommunicationConfigurationDto = Mapper.Map(CommunicationConfiguration);

            return OkResult( CustomMessage.DefaultMessage , CommunicationConfigurationDto);

        }
    }
}
