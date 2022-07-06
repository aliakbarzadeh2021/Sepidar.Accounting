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

namespace Sepidar.Api.Controllers.ContractSupportingInsuranceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractSupportingInsuranceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractSupportingInsuranceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractSupportingInsuranceCommand command)
        {
            command.Validate();

            var ContractSupportingInsurances = await _unitOfWork.ContractSupportingInsuranceRepository.FindAsync(c => c.Id == command.Id);

            if (ContractSupportingInsurances.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractSupportingInsurance = Mapper.Map(command);
            await _unitOfWork.ContractSupportingInsuranceRepository.AddAsync(newContractSupportingInsurance);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractSupportingInsuranceCommand command)
        {

            command.Validate();

            var ContractSupportingInsurance = await _unitOfWork.ContractSupportingInsuranceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractSupportingInsurance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractSupportingInsurance = Mapper.Map(ContractSupportingInsurance, command);
            ContractSupportingInsurance.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractSupportingInsurance = await _unitOfWork.ContractSupportingInsuranceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractSupportingInsurance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractSupportingInsurance.IsActive = false;
            ContractSupportingInsurance.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractSupportingInsurances = await _unitOfWork.ContractSupportingInsuranceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractSupportingInsurancesDto = Mapper.Map(ContractSupportingInsurances);

            return OkResult(CustomMessage.DefaultMessage, ContractSupportingInsurancesDto.ToPagingAndSorting(query), ContractSupportingInsurancesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractSupportingInsurance = await _unitOfWork.ContractSupportingInsuranceRepository.GetByIdAsync(id);

            if (ContractSupportingInsurance is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractSupportingInsuranceDto = Mapper.Map(ContractSupportingInsurance);

            return OkResult( CustomMessage.DefaultMessage , ContractSupportingInsuranceDto);

        }
    }
}
