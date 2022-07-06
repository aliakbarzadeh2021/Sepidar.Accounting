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

namespace Sepidar.Api.Controllers.POSSettlementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class POSSettlementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public POSSettlementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPOSSettlementCommand command)
        {
            command.Validate();

            var POSSettlements = await _unitOfWork.POSSettlementRepository.FindAsync(c => c.Id == command.Id);

            if (POSSettlements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPOSSettlement = Mapper.Map(command);
            await _unitOfWork.POSSettlementRepository.AddAsync(newPOSSettlement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPOSSettlementCommand command)
        {

            command.Validate();

            var POSSettlement = await _unitOfWork.POSSettlementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (POSSettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSSettlement = Mapper.Map(POSSettlement, command);
            POSSettlement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var POSSettlement = await _unitOfWork.POSSettlementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (POSSettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSSettlement.IsActive = false;
            POSSettlement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var POSSettlements = await _unitOfWork.POSSettlementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var POSSettlementsDto = Mapper.Map(POSSettlements);

            return OkResult(CustomMessage.DefaultMessage, POSSettlementsDto.ToPagingAndSorting(query), POSSettlementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var POSSettlement = await _unitOfWork.POSSettlementRepository.GetByIdAsync(id);

            if (POSSettlement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var POSSettlementDto = Mapper.Map(POSSettlement);

            return OkResult( CustomMessage.DefaultMessage , POSSettlementDto);

        }
    }
}
