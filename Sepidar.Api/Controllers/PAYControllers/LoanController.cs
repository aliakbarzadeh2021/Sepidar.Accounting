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

namespace Sepidar.Api.Controllers.LoanControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public LoanController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddLoanCommand command)
        {
            command.Validate();

            var Loans = await _unitOfWork.LoanRepository.FindAsync(c => c.Id == command.Id);

            if (Loans.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newLoan = Mapper.Map(command);
            await _unitOfWork.LoanRepository.AddAsync(newLoan);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditLoanCommand command)
        {

            command.Validate();

            var Loan = await _unitOfWork.LoanRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Loan == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Loan = Mapper.Map(Loan, command);
            Loan.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Loan = await _unitOfWork.LoanRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Loan == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Loan.IsActive = false;
            Loan.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Loans = await _unitOfWork.LoanRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var LoansDto = Mapper.Map(Loans);

            return OkResult(CustomMessage.DefaultMessage, LoansDto.ToPagingAndSorting(query), LoansDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Loan = await _unitOfWork.LoanRepository.GetByIdAsync(id);

            if (Loan is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var LoanDto = Mapper.Map(Loan);

            return OkResult( CustomMessage.DefaultMessage , LoanDto);

        }
    }
}
