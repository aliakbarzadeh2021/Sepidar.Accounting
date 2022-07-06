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

namespace Sepidar.Api.Controllers.SaleTypeConstraintItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SaleTypeConstraintItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SaleTypeConstraintItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSaleTypeConstraintItemCommand command)
        {
            command.Validate();

            var SaleTypeConstraintItems = await _unitOfWork.SaleTypeConstraintItemRepository.FindAsync(c => c.Id == command.Id);

            if (SaleTypeConstraintItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSaleTypeConstraintItem = Mapper.Map(command);
            await _unitOfWork.SaleTypeConstraintItemRepository.AddAsync(newSaleTypeConstraintItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSaleTypeConstraintItemCommand command)
        {

            command.Validate();

            var SaleTypeConstraintItem = await _unitOfWork.SaleTypeConstraintItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SaleTypeConstraintItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SaleTypeConstraintItem = Mapper.Map(SaleTypeConstraintItem, command);
            SaleTypeConstraintItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SaleTypeConstraintItem = await _unitOfWork.SaleTypeConstraintItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SaleTypeConstraintItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SaleTypeConstraintItem.IsActive = false;
            SaleTypeConstraintItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SaleTypeConstraintItems = await _unitOfWork.SaleTypeConstraintItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SaleTypeConstraintItemsDto = Mapper.Map(SaleTypeConstraintItems);

            return OkResult(CustomMessage.DefaultMessage, SaleTypeConstraintItemsDto.ToPagingAndSorting(query), SaleTypeConstraintItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SaleTypeConstraintItem = await _unitOfWork.SaleTypeConstraintItemRepository.GetByIdAsync(id);

            if (SaleTypeConstraintItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SaleTypeConstraintItemDto = Mapper.Map(SaleTypeConstraintItem);

            return OkResult( CustomMessage.DefaultMessage , SaleTypeConstraintItemDto);

        }
    }
}
