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

namespace Sepidar.Api.Controllers.InventoryWeighbridgeConfigurationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryWeighbridgeConfigurationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryWeighbridgeConfigurationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryWeighbridgeConfigurationCommand command)
        {
            command.Validate();

            var InventoryWeighbridgeConfigurations = await _unitOfWork.InventoryWeighbridgeConfigurationRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryWeighbridgeConfigurations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryWeighbridgeConfiguration = Mapper.Map(command);
            await _unitOfWork.InventoryWeighbridgeConfigurationRepository.AddAsync(newInventoryWeighbridgeConfiguration);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryWeighbridgeConfigurationCommand command)
        {

            command.Validate();

            var InventoryWeighbridgeConfiguration = await _unitOfWork.InventoryWeighbridgeConfigurationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryWeighbridgeConfiguration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryWeighbridgeConfiguration = Mapper.Map(InventoryWeighbridgeConfiguration, command);
            InventoryWeighbridgeConfiguration.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryWeighbridgeConfiguration = await _unitOfWork.InventoryWeighbridgeConfigurationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryWeighbridgeConfiguration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryWeighbridgeConfiguration.IsActive = false;
            InventoryWeighbridgeConfiguration.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryWeighbridgeConfigurations = await _unitOfWork.InventoryWeighbridgeConfigurationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryWeighbridgeConfigurationsDto = Mapper.Map(InventoryWeighbridgeConfigurations);

            return OkResult(CustomMessage.DefaultMessage, InventoryWeighbridgeConfigurationsDto.ToPagingAndSorting(query), InventoryWeighbridgeConfigurationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryWeighbridgeConfiguration = await _unitOfWork.InventoryWeighbridgeConfigurationRepository.GetByIdAsync(id);

            if (InventoryWeighbridgeConfiguration is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryWeighbridgeConfigurationDto = Mapper.Map(InventoryWeighbridgeConfiguration);

            return OkResult( CustomMessage.DefaultMessage , InventoryWeighbridgeConfigurationDto);

        }
    }
}
