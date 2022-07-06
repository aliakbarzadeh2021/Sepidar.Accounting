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

namespace Sepidar.Api.Controllers.PartySettlementItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartySettlementItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartySettlementItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartySettlementItemCommand command)
        {
            command.Validate();

            var PartySettlementItems = await _unitOfWork.PartySettlementItemRepository.FindAsync(c => c.Id == command.Id);

            if (PartySettlementItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartySettlementItem = Mapper.Map(command);
            await _unitOfWork.PartySettlementItemRepository.AddAsync(newPartySettlementItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartySettlementItemCommand command)
        {

            command.Validate();

            var PartySettlementItem = await _unitOfWork.PartySettlementItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartySettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartySettlementItem = Mapper.Map(PartySettlementItem, command);
            PartySettlementItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartySettlementItem = await _unitOfWork.PartySettlementItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartySettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartySettlementItem.IsActive = false;
            PartySettlementItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartySettlementItems = await _unitOfWork.PartySettlementItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartySettlementItemsDto = Mapper.Map(PartySettlementItems);

            return OkResult(CustomMessage.DefaultMessage, PartySettlementItemsDto.ToPagingAndSorting(query), PartySettlementItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartySettlementItem = await _unitOfWork.PartySettlementItemRepository.GetByIdAsync(id);

            if (PartySettlementItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartySettlementItemDto = Mapper.Map(PartySettlementItem);

            return OkResult( CustomMessage.DefaultMessage , PartySettlementItemDto);

        }
    }
}
