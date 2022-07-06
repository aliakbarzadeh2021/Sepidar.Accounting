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

namespace Sepidar.Api.Controllers.ReceiptPosControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReceiptPosController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReceiptPosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReceiptPosCommand command)
        {
            command.Validate();

            var ReceiptPoss = await _unitOfWork.ReceiptPosRepository.FindAsync(c => c.Id == command.Id);

            if (ReceiptPoss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReceiptPos = Mapper.Map(command);
            await _unitOfWork.ReceiptPosRepository.AddAsync(newReceiptPos);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReceiptPosCommand command)
        {

            command.Validate();

            var ReceiptPos = await _unitOfWork.ReceiptPosRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReceiptPos == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptPos = Mapper.Map(ReceiptPos, command);
            ReceiptPos.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReceiptPos = await _unitOfWork.ReceiptPosRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReceiptPos == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptPos.IsActive = false;
            ReceiptPos.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReceiptPoss = await _unitOfWork.ReceiptPosRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReceiptPossDto = Mapper.Map(ReceiptPoss);

            return OkResult(CustomMessage.DefaultMessage, ReceiptPossDto.ToPagingAndSorting(query), ReceiptPossDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReceiptPos = await _unitOfWork.ReceiptPosRepository.GetByIdAsync(id);

            if (ReceiptPos is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReceiptPosDto = Mapper.Map(ReceiptPos);

            return OkResult( CustomMessage.DefaultMessage , ReceiptPosDto);

        }
    }
}
