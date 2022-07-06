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

namespace Sepidar.Api.Controllers.DiscountItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DiscountItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DiscountItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDiscountItemCommand command)
        {
            command.Validate();

            var DiscountItems = await _unitOfWork.DiscountItemRepository.FindAsync(c => c.Id == command.Id);

            if (DiscountItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDiscountItem = Mapper.Map(command);
            await _unitOfWork.DiscountItemRepository.AddAsync(newDiscountItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDiscountItemCommand command)
        {

            command.Validate();

            var DiscountItem = await _unitOfWork.DiscountItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DiscountItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DiscountItem = Mapper.Map(DiscountItem, command);
            DiscountItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DiscountItem = await _unitOfWork.DiscountItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DiscountItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DiscountItem.IsActive = false;
            DiscountItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DiscountItems = await _unitOfWork.DiscountItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DiscountItemsDto = Mapper.Map(DiscountItems);

            return OkResult(CustomMessage.DefaultMessage, DiscountItemsDto.ToPagingAndSorting(query), DiscountItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DiscountItem = await _unitOfWork.DiscountItemRepository.GetByIdAsync(id);

            if (DiscountItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DiscountItemDto = Mapper.Map(DiscountItem);

            return OkResult( CustomMessage.DefaultMessage , DiscountItemDto);

        }
    }
}
