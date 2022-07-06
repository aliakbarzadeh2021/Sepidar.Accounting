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

namespace Sepidar.Api.Controllers.ChangeDepreciationMethodItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ChangeDepreciationMethodItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChangeDepreciationMethodItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddChangeDepreciationMethodItemCommand command)
        {
            command.Validate();

            var ChangeDepreciationMethodItems = await _unitOfWork.ChangeDepreciationMethodItemRepository.FindAsync(c => c.Id == command.Id);

            if (ChangeDepreciationMethodItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newChangeDepreciationMethodItem = Mapper.Map(command);
            await _unitOfWork.ChangeDepreciationMethodItemRepository.AddAsync(newChangeDepreciationMethodItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditChangeDepreciationMethodItemCommand command)
        {

            command.Validate();

            var ChangeDepreciationMethodItem = await _unitOfWork.ChangeDepreciationMethodItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ChangeDepreciationMethodItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ChangeDepreciationMethodItem = Mapper.Map(ChangeDepreciationMethodItem, command);
            ChangeDepreciationMethodItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ChangeDepreciationMethodItem = await _unitOfWork.ChangeDepreciationMethodItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ChangeDepreciationMethodItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ChangeDepreciationMethodItem.IsActive = false;
            ChangeDepreciationMethodItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ChangeDepreciationMethodItems = await _unitOfWork.ChangeDepreciationMethodItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ChangeDepreciationMethodItemsDto = Mapper.Map(ChangeDepreciationMethodItems);

            return OkResult(CustomMessage.DefaultMessage, ChangeDepreciationMethodItemsDto.ToPagingAndSorting(query), ChangeDepreciationMethodItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ChangeDepreciationMethodItem = await _unitOfWork.ChangeDepreciationMethodItemRepository.GetByIdAsync(id);

            if (ChangeDepreciationMethodItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ChangeDepreciationMethodItemDto = Mapper.Map(ChangeDepreciationMethodItem);

            return OkResult( CustomMessage.DefaultMessage , ChangeDepreciationMethodItemDto);

        }
    }
}
