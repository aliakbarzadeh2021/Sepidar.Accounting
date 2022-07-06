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

namespace Sepidar.Api.Controllers.BankBranchControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BankBranchController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BankBranchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBankBranchCommand command)
        {
            command.Validate();

            var BankBranchs = await _unitOfWork.BankBranchRepository.FindAsync(c => c.Id == command.Id);

            if (BankBranchs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBankBranch = Mapper.Map(command);
            await _unitOfWork.BankBranchRepository.AddAsync(newBankBranch);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBankBranchCommand command)
        {

            command.Validate();

            var BankBranch = await _unitOfWork.BankBranchRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BankBranch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankBranch = Mapper.Map(BankBranch, command);
            BankBranch.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BankBranch = await _unitOfWork.BankBranchRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BankBranch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankBranch.IsActive = false;
            BankBranch.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BankBranchs = await _unitOfWork.BankBranchRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BankBranchsDto = Mapper.Map(BankBranchs);

            return OkResult(CustomMessage.DefaultMessage, BankBranchsDto.ToPagingAndSorting(query), BankBranchsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BankBranch = await _unitOfWork.BankBranchRepository.GetByIdAsync(id);

            if (BankBranch is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BankBranchDto = Mapper.Map(BankBranch);

            return OkResult( CustomMessage.DefaultMessage , BankBranchDto);

        }
    }
}
