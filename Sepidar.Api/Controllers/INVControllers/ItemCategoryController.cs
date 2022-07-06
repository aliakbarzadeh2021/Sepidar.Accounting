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

namespace Sepidar.Api.Controllers.ItemCategoryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ItemCategoryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemCategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddItemCategoryCommand command)
        {
            command.Validate();

            var ItemCategorys = await _unitOfWork.ItemCategoryRepository.FindAsync(c => c.Id == command.Id);

            if (ItemCategorys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newItemCategory = Mapper.Map(command);
            await _unitOfWork.ItemCategoryRepository.AddAsync(newItemCategory);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditItemCategoryCommand command)
        {

            command.Validate();

            var ItemCategory = await _unitOfWork.ItemCategoryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ItemCategory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemCategory = Mapper.Map(ItemCategory, command);
            ItemCategory.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ItemCategory = await _unitOfWork.ItemCategoryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ItemCategory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemCategory.IsActive = false;
            ItemCategory.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ItemCategorys = await _unitOfWork.ItemCategoryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ItemCategorysDto = Mapper.Map(ItemCategorys);

            return OkResult(CustomMessage.DefaultMessage, ItemCategorysDto.ToPagingAndSorting(query), ItemCategorysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ItemCategory = await _unitOfWork.ItemCategoryRepository.GetByIdAsync(id);

            if (ItemCategory is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ItemCategoryDto = Mapper.Map(ItemCategory);

            return OkResult( CustomMessage.DefaultMessage , ItemCategoryDto);

        }
    }
}
