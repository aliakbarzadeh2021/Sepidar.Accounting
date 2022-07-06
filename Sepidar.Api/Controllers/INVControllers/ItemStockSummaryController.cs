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

namespace Sepidar.Api.Controllers.ItemStockSummaryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ItemStockSummaryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemStockSummaryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddItemStockSummaryCommand command)
        {
            command.Validate();

            var ItemStockSummarys = await _unitOfWork.ItemStockSummaryRepository.FindAsync(c => c.Id == command.Id);

            if (ItemStockSummarys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newItemStockSummary = Mapper.Map(command);
            await _unitOfWork.ItemStockSummaryRepository.AddAsync(newItemStockSummary);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditItemStockSummaryCommand command)
        {

            command.Validate();

            var ItemStockSummary = await _unitOfWork.ItemStockSummaryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ItemStockSummary == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemStockSummary = Mapper.Map(ItemStockSummary, command);
            ItemStockSummary.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ItemStockSummary = await _unitOfWork.ItemStockSummaryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ItemStockSummary == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemStockSummary.IsActive = false;
            ItemStockSummary.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ItemStockSummarys = await _unitOfWork.ItemStockSummaryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ItemStockSummarysDto = Mapper.Map(ItemStockSummarys);

            return OkResult(CustomMessage.DefaultMessage, ItemStockSummarysDto.ToPagingAndSorting(query), ItemStockSummarysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ItemStockSummary = await _unitOfWork.ItemStockSummaryRepository.GetByIdAsync(id);

            if (ItemStockSummary is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ItemStockSummaryDto = Mapper.Map(ItemStockSummary);

            return OkResult( CustomMessage.DefaultMessage , ItemStockSummaryDto);

        }
    }
}
