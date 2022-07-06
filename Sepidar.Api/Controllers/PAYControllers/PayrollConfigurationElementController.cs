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

namespace Sepidar.Api.Controllers.PayrollConfigurationElementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayrollConfigurationElementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayrollConfigurationElementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayrollConfigurationElementCommand command)
        {
            command.Validate();

            var PayrollConfigurationElements = await _unitOfWork.PayrollConfigurationElementRepository.FindAsync(c => c.Id == command.Id);

            if (PayrollConfigurationElements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayrollConfigurationElement = Mapper.Map(command);
            await _unitOfWork.PayrollConfigurationElementRepository.AddAsync(newPayrollConfigurationElement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayrollConfigurationElementCommand command)
        {

            command.Validate();

            var PayrollConfigurationElement = await _unitOfWork.PayrollConfigurationElementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayrollConfigurationElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayrollConfigurationElement = Mapper.Map(PayrollConfigurationElement, command);
            PayrollConfigurationElement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayrollConfigurationElement = await _unitOfWork.PayrollConfigurationElementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayrollConfigurationElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayrollConfigurationElement.IsActive = false;
            PayrollConfigurationElement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayrollConfigurationElements = await _unitOfWork.PayrollConfigurationElementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayrollConfigurationElementsDto = Mapper.Map(PayrollConfigurationElements);

            return OkResult(CustomMessage.DefaultMessage, PayrollConfigurationElementsDto.ToPagingAndSorting(query), PayrollConfigurationElementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayrollConfigurationElement = await _unitOfWork.PayrollConfigurationElementRepository.GetByIdAsync(id);

            if (PayrollConfigurationElement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayrollConfigurationElementDto = Mapper.Map(PayrollConfigurationElement);

            return OkResult( CustomMessage.DefaultMessage , PayrollConfigurationElementDto);

        }
    }
}
