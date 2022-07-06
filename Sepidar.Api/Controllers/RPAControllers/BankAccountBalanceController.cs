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

namespace Sepidar.Api.Controllers.BankAccountBalanceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BankAccountBalanceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BankAccountBalanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBankAccountBalanceCommand command)
        {
            command.Validate();

            var BankAccountBalances = await _unitOfWork.BankAccountBalanceRepository.FindAsync(c => c.Id == command.Id);

            if (BankAccountBalances.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBankAccountBalance = Mapper.Map(command);
            await _unitOfWork.BankAccountBalanceRepository.AddAsync(newBankAccountBalance);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBankAccountBalanceCommand command)
        {

            command.Validate();

            var BankAccountBalance = await _unitOfWork.BankAccountBalanceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BankAccountBalance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankAccountBalance = Mapper.Map(BankAccountBalance, command);
            BankAccountBalance.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BankAccountBalance = await _unitOfWork.BankAccountBalanceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BankAccountBalance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankAccountBalance.IsActive = false;
            BankAccountBalance.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BankAccountBalances = await _unitOfWork.BankAccountBalanceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BankAccountBalancesDto = Mapper.Map(BankAccountBalances);

            return OkResult(CustomMessage.DefaultMessage, BankAccountBalancesDto.ToPagingAndSorting(query), BankAccountBalancesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BankAccountBalance = await _unitOfWork.BankAccountBalanceRepository.GetByIdAsync(id);

            if (BankAccountBalance is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BankAccountBalanceDto = Mapper.Map(BankAccountBalance);

            return OkResult( CustomMessage.DefaultMessage , BankAccountBalanceDto);

        }
    }
}
