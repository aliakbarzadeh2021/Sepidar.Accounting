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

namespace Sepidar.Api.Controllers.ContractTypeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractTypeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractTypeCommand command)
        {
            command.Validate();

            var ContractTypes = await _unitOfWork.ContractTypeRepository.FindAsync(c => c.Id == command.Id);

            if (ContractTypes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractType = Mapper.Map(command);
            await _unitOfWork.ContractTypeRepository.AddAsync(newContractType);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractTypeCommand command)
        {

            command.Validate();

            var ContractType = await _unitOfWork.ContractTypeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractType = Mapper.Map(ContractType, command);
            ContractType.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractType = await _unitOfWork.ContractTypeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractType.IsActive = false;
            ContractType.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractTypes = await _unitOfWork.ContractTypeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractTypesDto = Mapper.Map(ContractTypes);

            return OkResult(CustomMessage.DefaultMessage, ContractTypesDto.ToPagingAndSorting(query), ContractTypesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractType = await _unitOfWork.ContractTypeRepository.GetByIdAsync(id);

            if (ContractType is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractTypeDto = Mapper.Map(ContractType);

            return OkResult( CustomMessage.DefaultMessage , ContractTypeDto);

        }
    }
}
