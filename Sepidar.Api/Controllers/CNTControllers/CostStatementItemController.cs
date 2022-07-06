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

namespace Sepidar.Api.Controllers.CostStatementItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CostStatementItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CostStatementItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCostStatementItemCommand command)
        {
            command.Validate();

            var CostStatementItems = await _unitOfWork.CostStatementItemRepository.FindAsync(c => c.Id == command.Id);

            if (CostStatementItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCostStatementItem = Mapper.Map(command);
            await _unitOfWork.CostStatementItemRepository.AddAsync(newCostStatementItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCostStatementItemCommand command)
        {

            command.Validate();

            var CostStatementItem = await _unitOfWork.CostStatementItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CostStatementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostStatementItem = Mapper.Map(CostStatementItem, command);
            CostStatementItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CostStatementItem = await _unitOfWork.CostStatementItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CostStatementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostStatementItem.IsActive = false;
            CostStatementItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CostStatementItems = await _unitOfWork.CostStatementItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CostStatementItemsDto = Mapper.Map(CostStatementItems);

            return OkResult(CustomMessage.DefaultMessage, CostStatementItemsDto.ToPagingAndSorting(query), CostStatementItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CostStatementItem = await _unitOfWork.CostStatementItemRepository.GetByIdAsync(id);

            if (CostStatementItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CostStatementItemDto = Mapper.Map(CostStatementItem);

            return OkResult( CustomMessage.DefaultMessage , CostStatementItemDto);

        }
    }
}
