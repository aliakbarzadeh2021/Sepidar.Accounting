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

namespace Sepidar.Api.Controllers.VatItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class VatItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public VatItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddVatItemCommand command)
        {
            command.Validate();

            var VatItems = await _unitOfWork.VatItemRepository.FindAsync(c => c.Id == command.Id);

            if (VatItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newVatItem = Mapper.Map(command);
            await _unitOfWork.VatItemRepository.AddAsync(newVatItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditVatItemCommand command)
        {

            command.Validate();

            var VatItem = await _unitOfWork.VatItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (VatItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            VatItem = Mapper.Map(VatItem, command);
            VatItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var VatItem = await _unitOfWork.VatItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (VatItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            VatItem.IsActive = false;
            VatItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var VatItems = await _unitOfWork.VatItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var VatItemsDto = Mapper.Map(VatItems);

            return OkResult(CustomMessage.DefaultMessage, VatItemsDto.ToPagingAndSorting(query), VatItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var VatItem = await _unitOfWork.VatItemRepository.GetByIdAsync(id);

            if (VatItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var VatItemDto = Mapper.Map(VatItem);

            return OkResult( CustomMessage.DefaultMessage , VatItemDto);

        }
    }
}
