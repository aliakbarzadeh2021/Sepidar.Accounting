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

namespace Sepidar.Api.Controllers.ContractSettlementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractSettlementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractSettlementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractSettlementCommand command)
        {
            command.Validate();

            var ContractSettlements = await _unitOfWork.ContractSettlementRepository.FindAsync(c => c.Id == command.Id);

            if (ContractSettlements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractSettlement = Mapper.Map(command);
            await _unitOfWork.ContractSettlementRepository.AddAsync(newContractSettlement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractSettlementCommand command)
        {

            command.Validate();

            var ContractSettlement = await _unitOfWork.ContractSettlementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractSettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractSettlement = Mapper.Map(ContractSettlement, command);
            ContractSettlement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractSettlement = await _unitOfWork.ContractSettlementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractSettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractSettlement.IsActive = false;
            ContractSettlement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractSettlements = await _unitOfWork.ContractSettlementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractSettlementsDto = Mapper.Map(ContractSettlements);

            return OkResult(CustomMessage.DefaultMessage, ContractSettlementsDto.ToPagingAndSorting(query), ContractSettlementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractSettlement = await _unitOfWork.ContractSettlementRepository.GetByIdAsync(id);

            if (ContractSettlement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractSettlementDto = Mapper.Map(ContractSettlement);

            return OkResult( CustomMessage.DefaultMessage , ContractSettlementDto);

        }
    }
}
