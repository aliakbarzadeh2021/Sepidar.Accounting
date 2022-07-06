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

namespace Sepidar.Api.Controllers.CostPartTransactionControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CostPartTransactionController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CostPartTransactionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCostPartTransactionCommand command)
        {
            command.Validate();

            var CostPartTransactions = await _unitOfWork.CostPartTransactionRepository.FindAsync(c => c.Id == command.Id);

            if (CostPartTransactions.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCostPartTransaction = Mapper.Map(command);
            await _unitOfWork.CostPartTransactionRepository.AddAsync(newCostPartTransaction);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCostPartTransactionCommand command)
        {

            command.Validate();

            var CostPartTransaction = await _unitOfWork.CostPartTransactionRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CostPartTransaction == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostPartTransaction = Mapper.Map(CostPartTransaction, command);
            CostPartTransaction.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CostPartTransaction = await _unitOfWork.CostPartTransactionRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CostPartTransaction == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostPartTransaction.IsActive = false;
            CostPartTransaction.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CostPartTransactions = await _unitOfWork.CostPartTransactionRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CostPartTransactionsDto = Mapper.Map(CostPartTransactions);

            return OkResult(CustomMessage.DefaultMessage, CostPartTransactionsDto.ToPagingAndSorting(query), CostPartTransactionsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CostPartTransaction = await _unitOfWork.CostPartTransactionRepository.GetByIdAsync(id);

            if (CostPartTransaction is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CostPartTransactionDto = Mapper.Map(CostPartTransaction);

            return OkResult( CustomMessage.DefaultMessage , CostPartTransactionDto);

        }
    }
}
