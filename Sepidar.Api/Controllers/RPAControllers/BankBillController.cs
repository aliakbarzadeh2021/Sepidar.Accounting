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

namespace Sepidar.Api.Controllers.BankBillControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BankBillController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BankBillController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBankBillCommand command)
        {
            command.Validate();

            var BankBills = await _unitOfWork.BankBillRepository.FindAsync(c => c.Id == command.Id);

            if (BankBills.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBankBill = Mapper.Map(command);
            await _unitOfWork.BankBillRepository.AddAsync(newBankBill);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBankBillCommand command)
        {

            command.Validate();

            var BankBill = await _unitOfWork.BankBillRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BankBill == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankBill = Mapper.Map(BankBill, command);
            BankBill.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BankBill = await _unitOfWork.BankBillRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BankBill == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BankBill.IsActive = false;
            BankBill.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BankBills = await _unitOfWork.BankBillRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BankBillsDto = Mapper.Map(BankBills);

            return OkResult(CustomMessage.DefaultMessage, BankBillsDto.ToPagingAndSorting(query), BankBillsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BankBill = await _unitOfWork.BankBillRepository.GetByIdAsync(id);

            if (BankBill is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BankBillDto = Mapper.Map(BankBill);

            return OkResult( CustomMessage.DefaultMessage , BankBillDto);

        }
    }
}
