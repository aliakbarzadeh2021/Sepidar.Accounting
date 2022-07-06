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

namespace Sepidar.Api.Controllers.HotDistributionItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HotDistributionItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HotDistributionItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHotDistributionItemCommand command)
        {
            command.Validate();

            var HotDistributionItems = await _unitOfWork.HotDistributionItemRepository.FindAsync(c => c.Id == command.Id);

            if (HotDistributionItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHotDistributionItem = Mapper.Map(command);
            await _unitOfWork.HotDistributionItemRepository.AddAsync(newHotDistributionItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHotDistributionItemCommand command)
        {

            command.Validate();

            var HotDistributionItem = await _unitOfWork.HotDistributionItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HotDistributionItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionItem = Mapper.Map(HotDistributionItem, command);
            HotDistributionItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HotDistributionItem = await _unitOfWork.HotDistributionItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HotDistributionItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionItem.IsActive = false;
            HotDistributionItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HotDistributionItems = await _unitOfWork.HotDistributionItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HotDistributionItemsDto = Mapper.Map(HotDistributionItems);

            return OkResult(CustomMessage.DefaultMessage, HotDistributionItemsDto.ToPagingAndSorting(query), HotDistributionItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HotDistributionItem = await _unitOfWork.HotDistributionItemRepository.GetByIdAsync(id);

            if (HotDistributionItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HotDistributionItemDto = Mapper.Map(HotDistributionItem);

            return OkResult( CustomMessage.DefaultMessage , HotDistributionItemDto);

        }
    }
}
