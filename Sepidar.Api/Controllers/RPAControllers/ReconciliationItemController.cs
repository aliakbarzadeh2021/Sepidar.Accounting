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

namespace Sepidar.Api.Controllers.ReconciliationItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReconciliationItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReconciliationItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReconciliationItemCommand command)
        {
            command.Validate();

            var ReconciliationItems = await _unitOfWork.ReconciliationItemRepository.FindAsync(c => c.Id == command.Id);

            if (ReconciliationItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReconciliationItem = Mapper.Map(command);
            await _unitOfWork.ReconciliationItemRepository.AddAsync(newReconciliationItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReconciliationItemCommand command)
        {

            command.Validate();

            var ReconciliationItem = await _unitOfWork.ReconciliationItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReconciliationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReconciliationItem = Mapper.Map(ReconciliationItem, command);
            ReconciliationItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReconciliationItem = await _unitOfWork.ReconciliationItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReconciliationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReconciliationItem.IsActive = false;
            ReconciliationItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReconciliationItems = await _unitOfWork.ReconciliationItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReconciliationItemsDto = Mapper.Map(ReconciliationItems);

            return OkResult(CustomMessage.DefaultMessage, ReconciliationItemsDto.ToPagingAndSorting(query), ReconciliationItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReconciliationItem = await _unitOfWork.ReconciliationItemRepository.GetByIdAsync(id);

            if (ReconciliationItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReconciliationItemDto = Mapper.Map(ReconciliationItem);

            return OkResult( CustomMessage.DefaultMessage , ReconciliationItemDto);

        }
    }
}
