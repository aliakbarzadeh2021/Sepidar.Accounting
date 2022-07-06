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

namespace Sepidar.Api.Controllers.RefundChequeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class RefundChequeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RefundChequeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddRefundChequeCommand command)
        {
            command.Validate();

            var RefundCheques = await _unitOfWork.RefundChequeRepository.FindAsync(c => c.Id == command.Id);

            if (RefundCheques.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newRefundCheque = Mapper.Map(command);
            await _unitOfWork.RefundChequeRepository.AddAsync(newRefundCheque);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditRefundChequeCommand command)
        {

            command.Validate();

            var RefundCheque = await _unitOfWork.RefundChequeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (RefundCheque == null)
                return NotFound(CustomMessage.NotFoundMessage);

            RefundCheque = Mapper.Map(RefundCheque, command);
            RefundCheque.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var RefundCheque = await _unitOfWork.RefundChequeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (RefundCheque == null)
                return NotFound(CustomMessage.NotFoundMessage);

            RefundCheque.IsActive = false;
            RefundCheque.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var RefundCheques = await _unitOfWork.RefundChequeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var RefundChequesDto = Mapper.Map(RefundCheques);

            return OkResult(CustomMessage.DefaultMessage, RefundChequesDto.ToPagingAndSorting(query), RefundChequesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var RefundCheque = await _unitOfWork.RefundChequeRepository.GetByIdAsync(id);

            if (RefundCheque is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var RefundChequeDto = Mapper.Map(RefundCheque);

            return OkResult( CustomMessage.DefaultMessage , RefundChequeDto);

        }
    }
}
