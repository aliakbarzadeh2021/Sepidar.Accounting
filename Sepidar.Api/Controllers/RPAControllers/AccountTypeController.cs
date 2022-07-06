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

namespace Sepidar.Api.Controllers.AccountTypeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccountTypeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccountTypeCommand command)
        {
            command.Validate();

            var AccountTypes = await _unitOfWork.AccountTypeRepository.FindAsync(c => c.Id == command.Id);

            if (AccountTypes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccountType = Mapper.Map(command);
            await _unitOfWork.AccountTypeRepository.AddAsync(newAccountType);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccountTypeCommand command)
        {

            command.Validate();

            var AccountType = await _unitOfWork.AccountTypeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccountType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccountType = Mapper.Map(AccountType, command);
            AccountType.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccountType = await _unitOfWork.AccountTypeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccountType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccountType.IsActive = false;
            AccountType.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccountTypes = await _unitOfWork.AccountTypeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccountTypesDto = Mapper.Map(AccountTypes);

            return OkResult(CustomMessage.DefaultMessage, AccountTypesDto.ToPagingAndSorting(query), AccountTypesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccountType = await _unitOfWork.AccountTypeRepository.GetByIdAsync(id);

            if (AccountType is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccountTypeDto = Mapper.Map(AccountType);

            return OkResult( CustomMessage.DefaultMessage , AccountTypeDto);

        }
    }
}
