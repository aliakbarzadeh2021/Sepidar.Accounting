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

namespace Sepidar.Api.Controllers.SettlementItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SettlementItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SettlementItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSettlementItemCommand command)
        {
            command.Validate();

            var SettlementItems = await _unitOfWork.SettlementItemRepository.FindAsync(c => c.Id == command.Id);

            if (SettlementItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSettlementItem = Mapper.Map(command);
            await _unitOfWork.SettlementItemRepository.AddAsync(newSettlementItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSettlementItemCommand command)
        {

            command.Validate();

            var SettlementItem = await _unitOfWork.SettlementItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SettlementItem = Mapper.Map(SettlementItem, command);
            SettlementItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SettlementItem = await _unitOfWork.SettlementItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SettlementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SettlementItem.IsActive = false;
            SettlementItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SettlementItems = await _unitOfWork.SettlementItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SettlementItemsDto = Mapper.Map(SettlementItems);

            return OkResult(CustomMessage.DefaultMessage, SettlementItemsDto.ToPagingAndSorting(query), SettlementItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SettlementItem = await _unitOfWork.SettlementItemRepository.GetByIdAsync(id);

            if (SettlementItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SettlementItemDto = Mapper.Map(SettlementItem);

            return OkResult( CustomMessage.DefaultMessage , SettlementItemDto);

        }
    }
}
