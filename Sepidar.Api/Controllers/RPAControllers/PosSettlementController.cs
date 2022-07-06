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

namespace Sepidar.Api.Controllers.PosSettlementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PosSettlementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PosSettlementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPosSettlementCommand command)
        {
            command.Validate();

            var PosSettlements = await _unitOfWork.PosSettlementRepository.FindAsync(c => c.Id == command.Id);

            if (PosSettlements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPosSettlement = Mapper.Map(command);
            await _unitOfWork.PosSettlementRepository.AddAsync(newPosSettlement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPosSettlementCommand command)
        {

            command.Validate();

            var PosSettlement = await _unitOfWork.PosSettlementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PosSettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PosSettlement = Mapper.Map(PosSettlement, command);
            PosSettlement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PosSettlement = await _unitOfWork.PosSettlementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PosSettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PosSettlement.IsActive = false;
            PosSettlement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PosSettlements = await _unitOfWork.PosSettlementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PosSettlementsDto = Mapper.Map(PosSettlements);

            return OkResult(CustomMessage.DefaultMessage, PosSettlementsDto.ToPagingAndSorting(query), PosSettlementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PosSettlement = await _unitOfWork.PosSettlementRepository.GetByIdAsync(id);

            if (PosSettlement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PosSettlementDto = Mapper.Map(PosSettlement);

            return OkResult( CustomMessage.DefaultMessage , PosSettlementDto);

        }
    }
}
