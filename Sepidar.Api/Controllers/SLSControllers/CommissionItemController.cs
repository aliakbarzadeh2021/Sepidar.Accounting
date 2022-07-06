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

namespace Sepidar.Api.Controllers.CommissionItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommissionItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommissionItemCommand command)
        {
            command.Validate();

            var CommissionItems = await _unitOfWork.CommissionItemRepository.FindAsync(c => c.Id == command.Id);

            if (CommissionItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommissionItem = Mapper.Map(command);
            await _unitOfWork.CommissionItemRepository.AddAsync(newCommissionItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommissionItemCommand command)
        {

            command.Validate();

            var CommissionItem = await _unitOfWork.CommissionItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommissionItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionItem = Mapper.Map(CommissionItem, command);
            CommissionItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommissionItem = await _unitOfWork.CommissionItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommissionItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionItem.IsActive = false;
            CommissionItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommissionItems = await _unitOfWork.CommissionItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommissionItemsDto = Mapper.Map(CommissionItems);

            return OkResult(CustomMessage.DefaultMessage, CommissionItemsDto.ToPagingAndSorting(query), CommissionItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommissionItem = await _unitOfWork.CommissionItemRepository.GetByIdAsync(id);

            if (CommissionItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommissionItemDto = Mapper.Map(CommissionItem);

            return OkResult( CustomMessage.DefaultMessage , CommissionItemDto);

        }
    }
}
