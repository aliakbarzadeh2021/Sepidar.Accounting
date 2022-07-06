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

namespace Sepidar.Api.Controllers.InsurancePolicyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InsurancePolicyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InsurancePolicyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInsurancePolicyCommand command)
        {
            command.Validate();

            var InsurancePolicys = await _unitOfWork.InsurancePolicyRepository.FindAsync(c => c.Id == command.Id);

            if (InsurancePolicys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInsurancePolicy = Mapper.Map(command);
            await _unitOfWork.InsurancePolicyRepository.AddAsync(newInsurancePolicy);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInsurancePolicyCommand command)
        {

            command.Validate();

            var InsurancePolicy = await _unitOfWork.InsurancePolicyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InsurancePolicy == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InsurancePolicy = Mapper.Map(InsurancePolicy, command);
            InsurancePolicy.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InsurancePolicy = await _unitOfWork.InsurancePolicyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InsurancePolicy == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InsurancePolicy.IsActive = false;
            InsurancePolicy.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InsurancePolicys = await _unitOfWork.InsurancePolicyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InsurancePolicysDto = Mapper.Map(InsurancePolicys);

            return OkResult(CustomMessage.DefaultMessage, InsurancePolicysDto.ToPagingAndSorting(query), InsurancePolicysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InsurancePolicy = await _unitOfWork.InsurancePolicyRepository.GetByIdAsync(id);

            if (InsurancePolicy is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InsurancePolicyDto = Mapper.Map(InsurancePolicy);

            return OkResult( CustomMessage.DefaultMessage , InsurancePolicyDto);

        }
    }
}
