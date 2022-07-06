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

namespace Sepidar.Api.Controllers.POSSettlementItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class POSSettlementItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public POSSettlementItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPOSSettlementItemCommand command)
        {
            command.Validate();

            var POSSettlementItems = await _unitOfWork.POSSettlementItemRepository.FindAsync(c => c.Id == command.Id);

            if (POSSettlementItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPOSSettlementItem = Mapper.Map(command);
            await _unitOfWork.POSSettlementItemRepository.AddAsync(newPOSSettlementItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPOSSettlementItemCommand command)
        {

            command.Validate();

            var POSSettlementItem = await _unitOfWork.POSSettlementItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (POSSettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSSettlementItem = Mapper.Map(POSSettlementItem, command);
            POSSettlementItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var POSSettlementItem = await _unitOfWork.POSSettlementItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (POSSettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSSettlementItem.IsActive = false;
            POSSettlementItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var POSSettlementItems = await _unitOfWork.POSSettlementItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var POSSettlementItemsDto = Mapper.Map(POSSettlementItems);

            return OkResult(CustomMessage.DefaultMessage, POSSettlementItemsDto.ToPagingAndSorting(query), POSSettlementItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var POSSettlementItem = await _unitOfWork.POSSettlementItemRepository.GetByIdAsync(id);

            if (POSSettlementItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var POSSettlementItemDto = Mapper.Map(POSSettlementItem);

            return OkResult( CustomMessage.DefaultMessage , POSSettlementItemDto);

        }
    }
}
