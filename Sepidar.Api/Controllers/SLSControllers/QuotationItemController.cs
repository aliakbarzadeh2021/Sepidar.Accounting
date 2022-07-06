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

namespace Sepidar.Api.Controllers.QuotationItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QuotationItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuotationItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQuotationItemCommand command)
        {
            command.Validate();

            var QuotationItems = await _unitOfWork.QuotationItemRepository.FindAsync(c => c.Id == command.Id);

            if (QuotationItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQuotationItem = Mapper.Map(command);
            await _unitOfWork.QuotationItemRepository.AddAsync(newQuotationItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQuotationItemCommand command)
        {

            command.Validate();

            var QuotationItem = await _unitOfWork.QuotationItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QuotationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuotationItem = Mapper.Map(QuotationItem, command);
            QuotationItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QuotationItem = await _unitOfWork.QuotationItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QuotationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuotationItem.IsActive = false;
            QuotationItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QuotationItems = await _unitOfWork.QuotationItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QuotationItemsDto = Mapper.Map(QuotationItems);

            return OkResult(CustomMessage.DefaultMessage, QuotationItemsDto.ToPagingAndSorting(query), QuotationItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QuotationItem = await _unitOfWork.QuotationItemRepository.GetByIdAsync(id);

            if (QuotationItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QuotationItemDto = Mapper.Map(QuotationItem);

            return OkResult( CustomMessage.DefaultMessage , QuotationItemDto);

        }
    }
}
