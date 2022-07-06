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

namespace Sepidar.Api.Controllers.PayrollConfigurationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayrollConfigurationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayrollConfigurationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayrollConfigurationCommand command)
        {
            command.Validate();

            var PayrollConfigurations = await _unitOfWork.PayrollConfigurationRepository.FindAsync(c => c.Id == command.Id);

            if (PayrollConfigurations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayrollConfiguration = Mapper.Map(command);
            await _unitOfWork.PayrollConfigurationRepository.AddAsync(newPayrollConfiguration);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayrollConfigurationCommand command)
        {

            command.Validate();

            var PayrollConfiguration = await _unitOfWork.PayrollConfigurationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayrollConfiguration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayrollConfiguration = Mapper.Map(PayrollConfiguration, command);
            PayrollConfiguration.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayrollConfiguration = await _unitOfWork.PayrollConfigurationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayrollConfiguration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayrollConfiguration.IsActive = false;
            PayrollConfiguration.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayrollConfigurations = await _unitOfWork.PayrollConfigurationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayrollConfigurationsDto = Mapper.Map(PayrollConfigurations);

            return OkResult(CustomMessage.DefaultMessage, PayrollConfigurationsDto.ToPagingAndSorting(query), PayrollConfigurationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayrollConfiguration = await _unitOfWork.PayrollConfigurationRepository.GetByIdAsync(id);

            if (PayrollConfiguration is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayrollConfigurationDto = Mapper.Map(PayrollConfiguration);

            return OkResult( CustomMessage.DefaultMessage , PayrollConfigurationDto);

        }
    }
}
