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

namespace Sepidar.Api.Controllers.ItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddItemCommand command)
        {
            command.Validate();

            var Items = await _unitOfWork.ItemRepository.FindAsync(c => c.Id == command.Id);

            if (Items.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newItem = Mapper.Map(command);
            await _unitOfWork.ItemRepository.AddAsync(newItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditItemCommand command)
        {

            command.Validate();

            var Item = await _unitOfWork.ItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Item == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Item = Mapper.Map(Item, command);
            Item.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Item = await _unitOfWork.ItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Item == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Item.IsActive = false;
            Item.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Items = await _unitOfWork.ItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ItemsDto = Mapper.Map(Items);

            return OkResult(CustomMessage.DefaultMessage, ItemsDto.ToPagingAndSorting(query), ItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Item = await _unitOfWork.ItemRepository.GetByIdAsync(id);

            if (Item is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ItemDto = Mapper.Map(Item);

            return OkResult( CustomMessage.DefaultMessage , ItemDto);

        }
    }
}
