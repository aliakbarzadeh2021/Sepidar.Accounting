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

namespace Sepidar.Api.Controllers.ElementItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ElementItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ElementItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddElementItemCommand command)
        {
            command.Validate();

            var ElementItems = await _unitOfWork.ElementItemRepository.FindAsync(c => c.Id == command.Id);

            if (ElementItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newElementItem = Mapper.Map(command);
            await _unitOfWork.ElementItemRepository.AddAsync(newElementItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditElementItemCommand command)
        {

            command.Validate();

            var ElementItem = await _unitOfWork.ElementItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ElementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElementItem = Mapper.Map(ElementItem, command);
            ElementItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ElementItem = await _unitOfWork.ElementItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ElementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElementItem.IsActive = false;
            ElementItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ElementItems = await _unitOfWork.ElementItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ElementItemsDto = Mapper.Map(ElementItems);

            return OkResult(CustomMessage.DefaultMessage, ElementItemsDto.ToPagingAndSorting(query), ElementItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ElementItem = await _unitOfWork.ElementItemRepository.GetByIdAsync(id);

            if (ElementItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ElementItemDto = Mapper.Map(ElementItem);

            return OkResult( CustomMessage.DefaultMessage , ElementItemDto);

        }
    }
}
