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

namespace Sepidar.Api.Controllers.QuickBarItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QuickBarItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuickBarItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQuickBarItemCommand command)
        {
            command.Validate();

            var QuickBarItems = await _unitOfWork.QuickBarItemRepository.FindAsync(c => c.Id == command.Id);

            if (QuickBarItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQuickBarItem = Mapper.Map(command);
            await _unitOfWork.QuickBarItemRepository.AddAsync(newQuickBarItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQuickBarItemCommand command)
        {

            command.Validate();

            var QuickBarItem = await _unitOfWork.QuickBarItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QuickBarItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuickBarItem = Mapper.Map(QuickBarItem, command);
            QuickBarItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QuickBarItem = await _unitOfWork.QuickBarItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QuickBarItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuickBarItem.IsActive = false;
            QuickBarItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QuickBarItems = await _unitOfWork.QuickBarItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QuickBarItemsDto = Mapper.Map(QuickBarItems);

            return OkResult(CustomMessage.DefaultMessage, QuickBarItemsDto.ToPagingAndSorting(query), QuickBarItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QuickBarItem = await _unitOfWork.QuickBarItemRepository.GetByIdAsync(id);

            if (QuickBarItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QuickBarItemDto = Mapper.Map(QuickBarItem);

            return OkResult( CustomMessage.DefaultMessage , QuickBarItemDto);

        }
    }
}
