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

namespace Sepidar.Api.Controllers.ShredItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShredItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShredItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddShredItemCommand command)
        {
            command.Validate();

            var ShredItems = await _unitOfWork.ShredItemRepository.FindAsync(c => c.Id == command.Id);

            if (ShredItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newShredItem = Mapper.Map(command);
            await _unitOfWork.ShredItemRepository.AddAsync(newShredItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditShredItemCommand command)
        {

            command.Validate();

            var ShredItem = await _unitOfWork.ShredItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ShredItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShredItem = Mapper.Map(ShredItem, command);
            ShredItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ShredItem = await _unitOfWork.ShredItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ShredItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShredItem.IsActive = false;
            ShredItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ShredItems = await _unitOfWork.ShredItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ShredItemsDto = Mapper.Map(ShredItems);

            return OkResult(CustomMessage.DefaultMessage, ShredItemsDto.ToPagingAndSorting(query), ShredItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ShredItem = await _unitOfWork.ShredItemRepository.GetByIdAsync(id);

            if (ShredItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ShredItemDto = Mapper.Map(ShredItem);

            return OkResult( CustomMessage.DefaultMessage , ShredItemDto);

        }
    }
}
