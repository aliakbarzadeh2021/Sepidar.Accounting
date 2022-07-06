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

namespace Sepidar.Api.Controllers.InvoiceItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvoiceItemCommand command)
        {
            command.Validate();

            var InvoiceItems = await _unitOfWork.InvoiceItemRepository.FindAsync(c => c.Id == command.Id);

            if (InvoiceItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvoiceItem = Mapper.Map(command);
            await _unitOfWork.InvoiceItemRepository.AddAsync(newInvoiceItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvoiceItemCommand command)
        {

            command.Validate();

            var InvoiceItem = await _unitOfWork.InvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceItem = Mapper.Map(InvoiceItem, command);
            InvoiceItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvoiceItem = await _unitOfWork.InvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceItem.IsActive = false;
            InvoiceItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvoiceItems = await _unitOfWork.InvoiceItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvoiceItemsDto = Mapper.Map(InvoiceItems);

            return OkResult(CustomMessage.DefaultMessage, InvoiceItemsDto.ToPagingAndSorting(query), InvoiceItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvoiceItem = await _unitOfWork.InvoiceItemRepository.GetByIdAsync(id);

            if (InvoiceItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvoiceItemDto = Mapper.Map(InvoiceItem);

            return OkResult( CustomMessage.DefaultMessage , InvoiceItemDto);

        }
    }
}
