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

namespace Sepidar.Api.Controllers.TransferControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TransferController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TransferController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTransferCommand command)
        {
            command.Validate();

            var Transfers = await _unitOfWork.TransferRepository.FindAsync(c => c.Id == command.Id);

            if (Transfers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTransfer = Mapper.Map(command);
            await _unitOfWork.TransferRepository.AddAsync(newTransfer);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTransferCommand command)
        {

            command.Validate();

            var Transfer = await _unitOfWork.TransferRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Transfer == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Transfer = Mapper.Map(Transfer, command);
            Transfer.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Transfer = await _unitOfWork.TransferRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Transfer == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Transfer.IsActive = false;
            Transfer.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Transfers = await _unitOfWork.TransferRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TransfersDto = Mapper.Map(Transfers);

            return OkResult(CustomMessage.DefaultMessage, TransfersDto.ToPagingAndSorting(query), TransfersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Transfer = await _unitOfWork.TransferRepository.GetByIdAsync(id);

            if (Transfer is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TransferDto = Mapper.Map(Transfer);

            return OkResult( CustomMessage.DefaultMessage , TransferDto);

        }
    }
}
