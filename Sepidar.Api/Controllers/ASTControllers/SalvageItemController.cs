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

namespace Sepidar.Api.Controllers.SalvageItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SalvageItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalvageItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSalvageItemCommand command)
        {
            command.Validate();

            var SalvageItems = await _unitOfWork.SalvageItemRepository.FindAsync(c => c.Id == command.Id);

            if (SalvageItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSalvageItem = Mapper.Map(command);
            await _unitOfWork.SalvageItemRepository.AddAsync(newSalvageItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSalvageItemCommand command)
        {

            command.Validate();

            var SalvageItem = await _unitOfWork.SalvageItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SalvageItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SalvageItem = Mapper.Map(SalvageItem, command);
            SalvageItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SalvageItem = await _unitOfWork.SalvageItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SalvageItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SalvageItem.IsActive = false;
            SalvageItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SalvageItems = await _unitOfWork.SalvageItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SalvageItemsDto = Mapper.Map(SalvageItems);

            return OkResult(CustomMessage.DefaultMessage, SalvageItemsDto.ToPagingAndSorting(query), SalvageItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SalvageItem = await _unitOfWork.SalvageItemRepository.GetByIdAsync(id);

            if (SalvageItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SalvageItemDto = Mapper.Map(SalvageItem);

            return OkResult( CustomMessage.DefaultMessage , SalvageItemDto);

        }
    }
}
