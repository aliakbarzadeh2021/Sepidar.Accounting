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

namespace Sepidar.Api.Controllers.VoucherItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class VoucherItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public VoucherItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddVoucherItemCommand command)
        {
            command.Validate();

            var VoucherItems = await _unitOfWork.VoucherItemRepository.FindAsync(c => c.Id == command.Id);

            if (VoucherItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newVoucherItem = Mapper.Map(command);
            await _unitOfWork.VoucherItemRepository.AddAsync(newVoucherItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditVoucherItemCommand command)
        {

            command.Validate();

            var VoucherItem = await _unitOfWork.VoucherItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (VoucherItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            VoucherItem = Mapper.Map(VoucherItem, command);
            VoucherItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var VoucherItem = await _unitOfWork.VoucherItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (VoucherItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            VoucherItem.IsActive = false;
            VoucherItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var VoucherItems = await _unitOfWork.VoucherItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var VoucherItemsDto = Mapper.Map(VoucherItems);

            return OkResult(CustomMessage.DefaultMessage, VoucherItemsDto.ToPagingAndSorting(query), VoucherItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var VoucherItem = await _unitOfWork.VoucherItemRepository.GetByIdAsync(id);

            if (VoucherItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var VoucherItemDto = Mapper.Map(VoucherItem);

            return OkResult( CustomMessage.DefaultMessage , VoucherItemDto);

        }
    }
}
