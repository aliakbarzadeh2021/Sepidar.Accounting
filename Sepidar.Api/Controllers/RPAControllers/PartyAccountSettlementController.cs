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

namespace Sepidar.Api.Controllers.PartyAccountSettlementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartyAccountSettlementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartyAccountSettlementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartyAccountSettlementCommand command)
        {
            command.Validate();

            var PartyAccountSettlements = await _unitOfWork.PartyAccountSettlementRepository.FindAsync(c => c.Id == command.Id);

            if (PartyAccountSettlements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartyAccountSettlement = Mapper.Map(command);
            await _unitOfWork.PartyAccountSettlementRepository.AddAsync(newPartyAccountSettlement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartyAccountSettlementCommand command)
        {

            command.Validate();

            var PartyAccountSettlement = await _unitOfWork.PartyAccountSettlementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartyAccountSettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyAccountSettlement = Mapper.Map(PartyAccountSettlement, command);
            PartyAccountSettlement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartyAccountSettlement = await _unitOfWork.PartyAccountSettlementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartyAccountSettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyAccountSettlement.IsActive = false;
            PartyAccountSettlement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartyAccountSettlements = await _unitOfWork.PartyAccountSettlementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartyAccountSettlementsDto = Mapper.Map(PartyAccountSettlements);

            return OkResult(CustomMessage.DefaultMessage, PartyAccountSettlementsDto.ToPagingAndSorting(query), PartyAccountSettlementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartyAccountSettlement = await _unitOfWork.PartyAccountSettlementRepository.GetByIdAsync(id);

            if (PartyAccountSettlement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartyAccountSettlementDto = Mapper.Map(PartyAccountSettlement);

            return OkResult( CustomMessage.DefaultMessage , PartyAccountSettlementDto);

        }
    }
}
