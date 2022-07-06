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

namespace Sepidar.Api.Controllers.DepreciationItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DepreciationItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepreciationItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDepreciationItemCommand command)
        {
            command.Validate();

            var DepreciationItems = await _unitOfWork.DepreciationItemRepository.FindAsync(c => c.Id == command.Id);

            if (DepreciationItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDepreciationItem = Mapper.Map(command);
            await _unitOfWork.DepreciationItemRepository.AddAsync(newDepreciationItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDepreciationItemCommand command)
        {

            command.Validate();

            var DepreciationItem = await _unitOfWork.DepreciationItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DepreciationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DepreciationItem = Mapper.Map(DepreciationItem, command);
            DepreciationItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DepreciationItem = await _unitOfWork.DepreciationItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DepreciationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DepreciationItem.IsActive = false;
            DepreciationItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DepreciationItems = await _unitOfWork.DepreciationItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DepreciationItemsDto = Mapper.Map(DepreciationItems);

            return OkResult(CustomMessage.DefaultMessage, DepreciationItemsDto.ToPagingAndSorting(query), DepreciationItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DepreciationItem = await _unitOfWork.DepreciationItemRepository.GetByIdAsync(id);

            if (DepreciationItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DepreciationItemDto = Mapper.Map(DepreciationItem);

            return OkResult( CustomMessage.DefaultMessage , DepreciationItemDto);

        }
    }
}
