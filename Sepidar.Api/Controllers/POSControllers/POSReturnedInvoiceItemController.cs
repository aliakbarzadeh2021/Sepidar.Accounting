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

namespace Sepidar.Api.Controllers.POSReturnedInvoiceItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class POSReturnedInvoiceItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public POSReturnedInvoiceItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPOSReturnedInvoiceItemCommand command)
        {
            command.Validate();

            var POSReturnedInvoiceItems = await _unitOfWork.POSReturnedInvoiceItemRepository.FindAsync(c => c.Id == command.Id);

            if (POSReturnedInvoiceItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPOSReturnedInvoiceItem = Mapper.Map(command);
            await _unitOfWork.POSReturnedInvoiceItemRepository.AddAsync(newPOSReturnedInvoiceItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPOSReturnedInvoiceItemCommand command)
        {

            command.Validate();

            var POSReturnedInvoiceItem = await _unitOfWork.POSReturnedInvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (POSReturnedInvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSReturnedInvoiceItem = Mapper.Map(POSReturnedInvoiceItem, command);
            POSReturnedInvoiceItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var POSReturnedInvoiceItem = await _unitOfWork.POSReturnedInvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (POSReturnedInvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            POSReturnedInvoiceItem.IsActive = false;
            POSReturnedInvoiceItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var POSReturnedInvoiceItems = await _unitOfWork.POSReturnedInvoiceItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var POSReturnedInvoiceItemsDto = Mapper.Map(POSReturnedInvoiceItems);

            return OkResult(CustomMessage.DefaultMessage, POSReturnedInvoiceItemsDto.ToPagingAndSorting(query), POSReturnedInvoiceItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var POSReturnedInvoiceItem = await _unitOfWork.POSReturnedInvoiceItemRepository.GetByIdAsync(id);

            if (POSReturnedInvoiceItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var POSReturnedInvoiceItemDto = Mapper.Map(POSReturnedInvoiceItem);

            return OkResult( CustomMessage.DefaultMessage , POSReturnedInvoiceItemDto);

        }
    }
}
