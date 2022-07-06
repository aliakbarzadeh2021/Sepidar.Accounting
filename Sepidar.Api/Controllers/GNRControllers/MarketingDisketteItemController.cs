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

namespace Sepidar.Api.Controllers.MarketingDisketteItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MarketingDisketteItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarketingDisketteItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMarketingDisketteItemCommand command)
        {
            command.Validate();

            var MarketingDisketteItems = await _unitOfWork.MarketingDisketteItemRepository.FindAsync(c => c.Id == command.Id);

            if (MarketingDisketteItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMarketingDisketteItem = Mapper.Map(command);
            await _unitOfWork.MarketingDisketteItemRepository.AddAsync(newMarketingDisketteItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMarketingDisketteItemCommand command)
        {

            command.Validate();

            var MarketingDisketteItem = await _unitOfWork.MarketingDisketteItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MarketingDisketteItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDisketteItem = Mapper.Map(MarketingDisketteItem, command);
            MarketingDisketteItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MarketingDisketteItem = await _unitOfWork.MarketingDisketteItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MarketingDisketteItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDisketteItem.IsActive = false;
            MarketingDisketteItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MarketingDisketteItems = await _unitOfWork.MarketingDisketteItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MarketingDisketteItemsDto = Mapper.Map(MarketingDisketteItems);

            return OkResult(CustomMessage.DefaultMessage, MarketingDisketteItemsDto.ToPagingAndSorting(query), MarketingDisketteItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MarketingDisketteItem = await _unitOfWork.MarketingDisketteItemRepository.GetByIdAsync(id);

            if (MarketingDisketteItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MarketingDisketteItemDto = Mapper.Map(MarketingDisketteItem);

            return OkResult( CustomMessage.DefaultMessage , MarketingDisketteItemDto);

        }
    }
}
