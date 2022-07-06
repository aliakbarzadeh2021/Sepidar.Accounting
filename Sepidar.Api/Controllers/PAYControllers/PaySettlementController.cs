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

namespace Sepidar.Api.Controllers.PaySettlementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PaySettlementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaySettlementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPaySettlementCommand command)
        {
            command.Validate();

            var PaySettlements = await _unitOfWork.PaySettlementRepository.FindAsync(c => c.Id == command.Id);

            if (PaySettlements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPaySettlement = Mapper.Map(command);
            await _unitOfWork.PaySettlementRepository.AddAsync(newPaySettlement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPaySettlementCommand command)
        {

            command.Validate();

            var PaySettlement = await _unitOfWork.PaySettlementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PaySettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaySettlement = Mapper.Map(PaySettlement, command);
            PaySettlement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PaySettlement = await _unitOfWork.PaySettlementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PaySettlement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PaySettlement.IsActive = false;
            PaySettlement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PaySettlements = await _unitOfWork.PaySettlementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PaySettlementsDto = Mapper.Map(PaySettlements);

            return OkResult(CustomMessage.DefaultMessage, PaySettlementsDto.ToPagingAndSorting(query), PaySettlementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PaySettlement = await _unitOfWork.PaySettlementRepository.GetByIdAsync(id);

            if (PaySettlement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PaySettlementDto = Mapper.Map(PaySettlement);

            return OkResult( CustomMessage.DefaultMessage , PaySettlementDto);

        }
    }
}
