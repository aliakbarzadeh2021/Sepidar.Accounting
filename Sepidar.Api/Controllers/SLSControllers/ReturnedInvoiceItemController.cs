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

namespace Sepidar.Api.Controllers.ReturnedInvoiceItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReturnedInvoiceItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReturnedInvoiceItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReturnedInvoiceItemCommand command)
        {
            command.Validate();

            var ReturnedInvoiceItems = await _unitOfWork.ReturnedInvoiceItemRepository.FindAsync(c => c.Id == command.Id);

            if (ReturnedInvoiceItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReturnedInvoiceItem = Mapper.Map(command);
            await _unitOfWork.ReturnedInvoiceItemRepository.AddAsync(newReturnedInvoiceItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReturnedInvoiceItemCommand command)
        {

            command.Validate();

            var ReturnedInvoiceItem = await _unitOfWork.ReturnedInvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoiceItem = Mapper.Map(ReturnedInvoiceItem, command);
            ReturnedInvoiceItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReturnedInvoiceItem = await _unitOfWork.ReturnedInvoiceItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoiceItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoiceItem.IsActive = false;
            ReturnedInvoiceItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReturnedInvoiceItems = await _unitOfWork.ReturnedInvoiceItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReturnedInvoiceItemsDto = Mapper.Map(ReturnedInvoiceItems);

            return OkResult(CustomMessage.DefaultMessage, ReturnedInvoiceItemsDto.ToPagingAndSorting(query), ReturnedInvoiceItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReturnedInvoiceItem = await _unitOfWork.ReturnedInvoiceItemRepository.GetByIdAsync(id);

            if (ReturnedInvoiceItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReturnedInvoiceItemDto = Mapper.Map(ReturnedInvoiceItem);

            return OkResult( CustomMessage.DefaultMessage , ReturnedInvoiceItemDto);

        }
    }
}
