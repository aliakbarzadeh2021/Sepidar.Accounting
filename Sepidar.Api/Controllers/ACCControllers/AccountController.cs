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

namespace Sepidar.Api.Controllers.AccountControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccountCommand command)
        {
            command.Validate();

            var Accounts = await _unitOfWork.AccountRepository.FindAsync(c => c.Id == command.Id);

            if (Accounts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccount = Mapper.Map(command);
            await _unitOfWork.AccountRepository.AddAsync(newAccount);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccountCommand command)
        {

            command.Validate();

            var Account = await _unitOfWork.AccountRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Account == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Account = Mapper.Map(Account, command);
            Account.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Account = await _unitOfWork.AccountRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Account == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Account.IsActive = false;
            Account.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Accounts = await _unitOfWork.AccountRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccountsDto = Mapper.Map(Accounts);

            return OkResult(CustomMessage.DefaultMessage, AccountsDto.ToPagingAndSorting(query), AccountsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Account = await _unitOfWork.AccountRepository.GetByIdAsync(id);

            if (Account is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccountDto = Mapper.Map(Account);

            return OkResult( CustomMessage.DefaultMessage , AccountDto);

        }
    }
}
