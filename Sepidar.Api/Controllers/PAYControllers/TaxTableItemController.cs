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

namespace Sepidar.Api.Controllers.TaxTableItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TaxTableItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TaxTableItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTaxTableItemCommand command)
        {
            command.Validate();

            var TaxTableItems = await _unitOfWork.TaxTableItemRepository.FindAsync(c => c.Id == command.Id);

            if (TaxTableItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTaxTableItem = Mapper.Map(command);
            await _unitOfWork.TaxTableItemRepository.AddAsync(newTaxTableItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTaxTableItemCommand command)
        {

            command.Validate();

            var TaxTableItem = await _unitOfWork.TaxTableItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TaxTableItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TaxTableItem = Mapper.Map(TaxTableItem, command);
            TaxTableItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TaxTableItem = await _unitOfWork.TaxTableItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TaxTableItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TaxTableItem.IsActive = false;
            TaxTableItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TaxTableItems = await _unitOfWork.TaxTableItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TaxTableItemsDto = Mapper.Map(TaxTableItems);

            return OkResult(CustomMessage.DefaultMessage, TaxTableItemsDto.ToPagingAndSorting(query), TaxTableItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TaxTableItem = await _unitOfWork.TaxTableItemRepository.GetByIdAsync(id);

            if (TaxTableItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TaxTableItemDto = Mapper.Map(TaxTableItem);

            return OkResult( CustomMessage.DefaultMessage , TaxTableItemDto);

        }
    }
}
