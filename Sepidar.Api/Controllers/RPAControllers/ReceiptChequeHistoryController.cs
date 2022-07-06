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

namespace Sepidar.Api.Controllers.ReceiptChequeHistoryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReceiptChequeHistoryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReceiptChequeHistoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReceiptChequeHistoryCommand command)
        {
            command.Validate();

            var ReceiptChequeHistorys = await _unitOfWork.ReceiptChequeHistoryRepository.FindAsync(c => c.Id == command.Id);

            if (ReceiptChequeHistorys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReceiptChequeHistory = Mapper.Map(command);
            await _unitOfWork.ReceiptChequeHistoryRepository.AddAsync(newReceiptChequeHistory);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReceiptChequeHistoryCommand command)
        {

            command.Validate();

            var ReceiptChequeHistory = await _unitOfWork.ReceiptChequeHistoryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReceiptChequeHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptChequeHistory = Mapper.Map(ReceiptChequeHistory, command);
            ReceiptChequeHistory.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReceiptChequeHistory = await _unitOfWork.ReceiptChequeHistoryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReceiptChequeHistory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptChequeHistory.IsActive = false;
            ReceiptChequeHistory.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReceiptChequeHistorys = await _unitOfWork.ReceiptChequeHistoryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReceiptChequeHistorysDto = Mapper.Map(ReceiptChequeHistorys);

            return OkResult(CustomMessage.DefaultMessage, ReceiptChequeHistorysDto.ToPagingAndSorting(query), ReceiptChequeHistorysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReceiptChequeHistory = await _unitOfWork.ReceiptChequeHistoryRepository.GetByIdAsync(id);

            if (ReceiptChequeHistory is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReceiptChequeHistoryDto = Mapper.Map(ReceiptChequeHistory);

            return OkResult( CustomMessage.DefaultMessage , ReceiptChequeHistoryDto);

        }
    }
}
