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

namespace Sepidar.Api.Controllers.ItemImageControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ItemImageController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemImageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddItemImageCommand command)
        {
            command.Validate();

            var ItemImages = await _unitOfWork.ItemImageRepository.FindAsync(c => c.Id == command.Id);

            if (ItemImages.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newItemImage = Mapper.Map(command);
            await _unitOfWork.ItemImageRepository.AddAsync(newItemImage);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditItemImageCommand command)
        {

            command.Validate();

            var ItemImage = await _unitOfWork.ItemImageRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ItemImage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemImage = Mapper.Map(ItemImage, command);
            ItemImage.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ItemImage = await _unitOfWork.ItemImageRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ItemImage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemImage.IsActive = false;
            ItemImage.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ItemImages = await _unitOfWork.ItemImageRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ItemImagesDto = Mapper.Map(ItemImages);

            return OkResult(CustomMessage.DefaultMessage, ItemImagesDto.ToPagingAndSorting(query), ItemImagesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ItemImage = await _unitOfWork.ItemImageRepository.GetByIdAsync(id);

            if (ItemImage is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ItemImageDto = Mapper.Map(ItemImage);

            return OkResult( CustomMessage.DefaultMessage , ItemImageDto);

        }
    }
}
