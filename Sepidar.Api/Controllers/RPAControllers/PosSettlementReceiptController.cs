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

namespace Sepidar.Api.Controllers.PosSettlementReceiptControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PosSettlementReceiptController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PosSettlementReceiptController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPosSettlementReceiptCommand command)
        {
            command.Validate();

            var PosSettlementReceipts = await _unitOfWork.PosSettlementReceiptRepository.FindAsync(c => c.Id == command.Id);

            if (PosSettlementReceipts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPosSettlementReceipt = Mapper.Map(command);
            await _unitOfWork.PosSettlementReceiptRepository.AddAsync(newPosSettlementReceipt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPosSettlementReceiptCommand command)
        {

            command.Validate();

            var PosSettlementReceipt = await _unitOfWork.PosSettlementReceiptRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PosSettlementReceipt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PosSettlementReceipt = Mapper.Map(PosSettlementReceipt, command);
            PosSettlementReceipt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PosSettlementReceipt = await _unitOfWork.PosSettlementReceiptRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PosSettlementReceipt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PosSettlementReceipt.IsActive = false;
            PosSettlementReceipt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PosSettlementReceipts = await _unitOfWork.PosSettlementReceiptRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PosSettlementReceiptsDto = Mapper.Map(PosSettlementReceipts);

            return OkResult(CustomMessage.DefaultMessage, PosSettlementReceiptsDto.ToPagingAndSorting(query), PosSettlementReceiptsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PosSettlementReceipt = await _unitOfWork.PosSettlementReceiptRepository.GetByIdAsync(id);

            if (PosSettlementReceipt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PosSettlementReceiptDto = Mapper.Map(PosSettlementReceipt);

            return OkResult( CustomMessage.DefaultMessage , PosSettlementReceiptDto);

        }
    }
}
