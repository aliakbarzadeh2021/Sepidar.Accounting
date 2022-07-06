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

namespace Sepidar.Api.Controllers.ContractControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractCommand command)
        {
            command.Validate();

            var Contracts = await _unitOfWork.ContractRepository.FindAsync(c => c.Id == command.Id);

            if (Contracts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContract = Mapper.Map(command);
            await _unitOfWork.ContractRepository.AddAsync(newContract);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractCommand command)
        {

            command.Validate();

            var Contract = await _unitOfWork.ContractRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Contract == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Contract = Mapper.Map(Contract, command);
            Contract.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Contract = await _unitOfWork.ContractRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Contract == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Contract.IsActive = false;
            Contract.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Contracts = await _unitOfWork.ContractRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractsDto = Mapper.Map(Contracts);

            return OkResult(CustomMessage.DefaultMessage, ContractsDto.ToPagingAndSorting(query), ContractsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Contract = await _unitOfWork.ContractRepository.GetByIdAsync(id);

            if (Contract is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractDto = Mapper.Map(Contract);

            return OkResult( CustomMessage.DefaultMessage , ContractDto);

        }
    }
}
