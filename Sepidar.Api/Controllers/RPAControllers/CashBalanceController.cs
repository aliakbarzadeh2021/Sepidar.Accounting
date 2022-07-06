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

namespace Sepidar.Api.Controllers.CashBalanceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CashBalanceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CashBalanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCashBalanceCommand command)
        {
            command.Validate();

            var CashBalances = await _unitOfWork.CashBalanceRepository.FindAsync(c => c.Id == command.Id);

            if (CashBalances.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCashBalance = Mapper.Map(command);
            await _unitOfWork.CashBalanceRepository.AddAsync(newCashBalance);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCashBalanceCommand command)
        {

            command.Validate();

            var CashBalance = await _unitOfWork.CashBalanceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CashBalance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CashBalance = Mapper.Map(CashBalance, command);
            CashBalance.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CashBalance = await _unitOfWork.CashBalanceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CashBalance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CashBalance.IsActive = false;
            CashBalance.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CashBalances = await _unitOfWork.CashBalanceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CashBalancesDto = Mapper.Map(CashBalances);

            return OkResult(CustomMessage.DefaultMessage, CashBalancesDto.ToPagingAndSorting(query), CashBalancesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CashBalance = await _unitOfWork.CashBalanceRepository.GetByIdAsync(id);

            if (CashBalance is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CashBalanceDto = Mapper.Map(CashBalance);

            return OkResult( CustomMessage.DefaultMessage , CashBalanceDto);

        }
    }
}
