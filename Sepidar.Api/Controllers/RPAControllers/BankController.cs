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

namespace Sepidar.Api.Controllers.BankControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BankController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BankController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBankCommand command)
        {
            command.Validate();

            var Banks = await _unitOfWork.BankRepository.FindAsync(c => c.Id == command.Id);

            if (Banks.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBank = Mapper.Map(command);
            await _unitOfWork.BankRepository.AddAsync(newBank);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBankCommand command)
        {

            command.Validate();

            var Bank = await _unitOfWork.BankRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Bank == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Bank = Mapper.Map(Bank, command);
            Bank.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Bank = await _unitOfWork.BankRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Bank == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Bank.IsActive = false;
            Bank.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Banks = await _unitOfWork.BankRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BanksDto = Mapper.Map(Banks);

            return OkResult(CustomMessage.DefaultMessage, BanksDto.ToPagingAndSorting(query), BanksDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Bank = await _unitOfWork.BankRepository.GetByIdAsync(id);

            if (Bank is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BankDto = Mapper.Map(Bank);

            return OkResult( CustomMessage.DefaultMessage , BankDto);

        }
    }
}
