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

namespace Sepidar.Api.Controllers.CustomsClearanceItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CustomsClearanceItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomsClearanceItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCustomsClearanceItemCommand command)
        {
            command.Validate();

            var CustomsClearanceItems = await _unitOfWork.CustomsClearanceItemRepository.FindAsync(c => c.Id == command.Id);

            if (CustomsClearanceItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCustomsClearanceItem = Mapper.Map(command);
            await _unitOfWork.CustomsClearanceItemRepository.AddAsync(newCustomsClearanceItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCustomsClearanceItemCommand command)
        {

            command.Validate();

            var CustomsClearanceItem = await _unitOfWork.CustomsClearanceItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CustomsClearanceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CustomsClearanceItem = Mapper.Map(CustomsClearanceItem, command);
            CustomsClearanceItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CustomsClearanceItem = await _unitOfWork.CustomsClearanceItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CustomsClearanceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CustomsClearanceItem.IsActive = false;
            CustomsClearanceItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CustomsClearanceItems = await _unitOfWork.CustomsClearanceItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CustomsClearanceItemsDto = Mapper.Map(CustomsClearanceItems);

            return OkResult(CustomMessage.DefaultMessage, CustomsClearanceItemsDto.ToPagingAndSorting(query), CustomsClearanceItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CustomsClearanceItem = await _unitOfWork.CustomsClearanceItemRepository.GetByIdAsync(id);

            if (CustomsClearanceItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CustomsClearanceItemDto = Mapper.Map(CustomsClearanceItem);

            return OkResult( CustomMessage.DefaultMessage , CustomsClearanceItemDto);

        }
    }
}
