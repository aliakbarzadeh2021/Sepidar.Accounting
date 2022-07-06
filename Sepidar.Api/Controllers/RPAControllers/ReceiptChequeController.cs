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

namespace Sepidar.Api.Controllers.ReceiptChequeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReceiptChequeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReceiptChequeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReceiptChequeCommand command)
        {
            command.Validate();

            var ReceiptCheques = await _unitOfWork.ReceiptChequeRepository.FindAsync(c => c.Id == command.Id);

            if (ReceiptCheques.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReceiptCheque = Mapper.Map(command);
            await _unitOfWork.ReceiptChequeRepository.AddAsync(newReceiptCheque);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReceiptChequeCommand command)
        {

            command.Validate();

            var ReceiptCheque = await _unitOfWork.ReceiptChequeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReceiptCheque == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptCheque = Mapper.Map(ReceiptCheque, command);
            ReceiptCheque.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReceiptCheque = await _unitOfWork.ReceiptChequeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReceiptCheque == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptCheque.IsActive = false;
            ReceiptCheque.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReceiptCheques = await _unitOfWork.ReceiptChequeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReceiptChequesDto = Mapper.Map(ReceiptCheques);

            return OkResult(CustomMessage.DefaultMessage, ReceiptChequesDto.ToPagingAndSorting(query), ReceiptChequesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReceiptCheque = await _unitOfWork.ReceiptChequeRepository.GetByIdAsync(id);

            if (ReceiptCheque is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReceiptChequeDto = Mapper.Map(ReceiptCheque);

            return OkResult( CustomMessage.DefaultMessage , ReceiptChequeDto);

        }
    }
}
