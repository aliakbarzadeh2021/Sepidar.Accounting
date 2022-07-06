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

namespace Sepidar.Api.Controllers.PartySettlementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartySettlementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartySettlementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartySettlementCommand command)
        {
            command.Validate();

            var PartySettlements = await _unitOfWork.PartySettlementRepository.FindAsync(c => c.Id == command.Id);

            if (PartySettlements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartySettlement = Mapper.Map(command);
            await _unitOfWork.PartySettlementRepository.AddAsync(newPartySettlement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartySettlementCommand command)
        {

            command.Validate();

            var PartySettlement = await _unitOfWork.PartySettlementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartySettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartySettlement = Mapper.Map(PartySettlement, command);
            PartySettlement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartySettlement = await _unitOfWork.PartySettlementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartySettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartySettlement.IsActive = false;
            PartySettlement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartySettlements = await _unitOfWork.PartySettlementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartySettlementsDto = Mapper.Map(PartySettlements);

            return OkResult(CustomMessage.DefaultMessage, PartySettlementsDto.ToPagingAndSorting(query), PartySettlementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartySettlement = await _unitOfWork.PartySettlementRepository.GetByIdAsync(id);

            if (PartySettlement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartySettlementDto = Mapper.Map(PartySettlement);

            return OkResult( CustomMessage.DefaultMessage , PartySettlementDto);

        }
    }
}
