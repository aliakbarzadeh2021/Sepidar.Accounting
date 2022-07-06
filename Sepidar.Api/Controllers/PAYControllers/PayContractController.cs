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

namespace Sepidar.Api.Controllers.PayContractControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PayContractController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PayContractController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPayContractCommand command)
        {
            command.Validate();

            var PayContracts = await _unitOfWork.PayContractRepository.FindAsync(c => c.Id == command.Id);

            if (PayContracts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPayContract = Mapper.Map(command);
            await _unitOfWork.PayContractRepository.AddAsync(newPayContract);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPayContractCommand command)
        {

            command.Validate();

            var PayContract = await _unitOfWork.PayContractRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PayContract == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayContract = Mapper.Map(PayContract, command);
            PayContract.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PayContract = await _unitOfWork.PayContractRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PayContract == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PayContract.IsActive = false;
            PayContract.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PayContracts = await _unitOfWork.PayContractRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PayContractsDto = Mapper.Map(PayContracts);

            return OkResult(CustomMessage.DefaultMessage, PayContractsDto.ToPagingAndSorting(query), PayContractsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PayContract = await _unitOfWork.PayContractRepository.GetByIdAsync(id);

            if (PayContract is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PayContractDto = Mapper.Map(PayContract);

            return OkResult( CustomMessage.DefaultMessage , PayContractDto);

        }
    }
}
