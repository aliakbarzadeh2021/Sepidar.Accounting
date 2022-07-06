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

namespace Sepidar.Api.Controllers.BankAccountControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BankAccountController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BankAccountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBankAccountCommand command)
        {
            command.Validate();

            var BankAccounts = await _unitOfWork.BankAccountRepository.FindAsync(c => c.Id == command.Id);

            if (BankAccounts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBankAccount = Mapper.Map(command);
            await _unitOfWork.BankAccountRepository.AddAsync(newBankAccount);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBankAccountCommand command)
        {

            command.Validate();

            var BankAccount = await _unitOfWork.BankAccountRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BankAccount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankAccount = Mapper.Map(BankAccount, command);
            BankAccount.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BankAccount = await _unitOfWork.BankAccountRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BankAccount == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankAccount.IsActive = false;
            BankAccount.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BankAccounts = await _unitOfWork.BankAccountRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BankAccountsDto = Mapper.Map(BankAccounts);

            return OkResult(CustomMessage.DefaultMessage, BankAccountsDto.ToPagingAndSorting(query), BankAccountsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BankAccount = await _unitOfWork.BankAccountRepository.GetByIdAsync(id);

            if (BankAccount is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BankAccountDto = Mapper.Map(BankAccount);

            return OkResult( CustomMessage.DefaultMessage , BankAccountDto);

        }
    }
}
