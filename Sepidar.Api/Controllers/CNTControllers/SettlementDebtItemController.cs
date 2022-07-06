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

namespace Sepidar.Api.Controllers.SettlementDebtItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SettlementDebtItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SettlementDebtItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSettlementDebtItemCommand command)
        {
            command.Validate();

            var SettlementDebtItems = await _unitOfWork.SettlementDebtItemRepository.FindAsync(c => c.Id == command.Id);

            if (SettlementDebtItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSettlementDebtItem = Mapper.Map(command);
            await _unitOfWork.SettlementDebtItemRepository.AddAsync(newSettlementDebtItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSettlementDebtItemCommand command)
        {

            command.Validate();

            var SettlementDebtItem = await _unitOfWork.SettlementDebtItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SettlementDebtItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SettlementDebtItem = Mapper.Map(SettlementDebtItem, command);
            SettlementDebtItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SettlementDebtItem = await _unitOfWork.SettlementDebtItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SettlementDebtItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SettlementDebtItem.IsActive = false;
            SettlementDebtItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SettlementDebtItems = await _unitOfWork.SettlementDebtItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SettlementDebtItemsDto = Mapper.Map(SettlementDebtItems);

            return OkResult(CustomMessage.DefaultMessage, SettlementDebtItemsDto.ToPagingAndSorting(query), SettlementDebtItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SettlementDebtItem = await _unitOfWork.SettlementDebtItemRepository.GetByIdAsync(id);

            if (SettlementDebtItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SettlementDebtItemDto = Mapper.Map(SettlementDebtItem);

            return OkResult( CustomMessage.DefaultMessage , SettlementDebtItemDto);

        }
    }
}
