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

namespace Sepidar.Api.Controllers.PartyAccountSettlementItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartyAccountSettlementItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartyAccountSettlementItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartyAccountSettlementItemCommand command)
        {
            command.Validate();

            var PartyAccountSettlementItems = await _unitOfWork.PartyAccountSettlementItemRepository.FindAsync(c => c.Id == command.Id);

            if (PartyAccountSettlementItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartyAccountSettlementItem = Mapper.Map(command);
            await _unitOfWork.PartyAccountSettlementItemRepository.AddAsync(newPartyAccountSettlementItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartyAccountSettlementItemCommand command)
        {

            command.Validate();

            var PartyAccountSettlementItem = await _unitOfWork.PartyAccountSettlementItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartyAccountSettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyAccountSettlementItem = Mapper.Map(PartyAccountSettlementItem, command);
            PartyAccountSettlementItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartyAccountSettlementItem = await _unitOfWork.PartyAccountSettlementItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartyAccountSettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyAccountSettlementItem.IsActive = false;
            PartyAccountSettlementItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartyAccountSettlementItems = await _unitOfWork.PartyAccountSettlementItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartyAccountSettlementItemsDto = Mapper.Map(PartyAccountSettlementItems);

            return OkResult(CustomMessage.DefaultMessage, PartyAccountSettlementItemsDto.ToPagingAndSorting(query), PartyAccountSettlementItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartyAccountSettlementItem = await _unitOfWork.PartyAccountSettlementItemRepository.GetByIdAsync(id);

            if (PartyAccountSettlementItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartyAccountSettlementItemDto = Mapper.Map(PartyAccountSettlementItem);

            return OkResult( CustomMessage.DefaultMessage , PartyAccountSettlementItemDto);

        }
    }
}
