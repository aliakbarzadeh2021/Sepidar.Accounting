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

namespace Sepidar.Api.Controllers.TransferItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TransferItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TransferItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTransferItemCommand command)
        {
            command.Validate();

            var TransferItems = await _unitOfWork.TransferItemRepository.FindAsync(c => c.Id == command.Id);

            if (TransferItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTransferItem = Mapper.Map(command);
            await _unitOfWork.TransferItemRepository.AddAsync(newTransferItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTransferItemCommand command)
        {

            command.Validate();

            var TransferItem = await _unitOfWork.TransferItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TransferItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TransferItem = Mapper.Map(TransferItem, command);
            TransferItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TransferItem = await _unitOfWork.TransferItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TransferItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TransferItem.IsActive = false;
            TransferItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TransferItems = await _unitOfWork.TransferItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TransferItemsDto = Mapper.Map(TransferItems);

            return OkResult(CustomMessage.DefaultMessage, TransferItemsDto.ToPagingAndSorting(query), TransferItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TransferItem = await _unitOfWork.TransferItemRepository.GetByIdAsync(id);

            if (TransferItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TransferItemDto = Mapper.Map(TransferItem);

            return OkResult( CustomMessage.DefaultMessage , TransferItemDto);

        }
    }
}
