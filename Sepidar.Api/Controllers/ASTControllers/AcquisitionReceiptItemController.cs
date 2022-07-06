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

namespace Sepidar.Api.Controllers.AcquisitionReceiptItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AcquisitionReceiptItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AcquisitionReceiptItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAcquisitionReceiptItemCommand command)
        {
            command.Validate();

            var AcquisitionReceiptItems = await _unitOfWork.AcquisitionReceiptItemRepository.FindAsync(c => c.Id == command.Id);

            if (AcquisitionReceiptItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAcquisitionReceiptItem = Mapper.Map(command);
            await _unitOfWork.AcquisitionReceiptItemRepository.AddAsync(newAcquisitionReceiptItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAcquisitionReceiptItemCommand command)
        {

            command.Validate();

            var AcquisitionReceiptItem = await _unitOfWork.AcquisitionReceiptItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AcquisitionReceiptItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AcquisitionReceiptItem = Mapper.Map(AcquisitionReceiptItem, command);
            AcquisitionReceiptItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AcquisitionReceiptItem = await _unitOfWork.AcquisitionReceiptItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AcquisitionReceiptItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AcquisitionReceiptItem.IsActive = false;
            AcquisitionReceiptItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AcquisitionReceiptItems = await _unitOfWork.AcquisitionReceiptItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AcquisitionReceiptItemsDto = Mapper.Map(AcquisitionReceiptItems);

            return OkResult(CustomMessage.DefaultMessage, AcquisitionReceiptItemsDto.ToPagingAndSorting(query), AcquisitionReceiptItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AcquisitionReceiptItem = await _unitOfWork.AcquisitionReceiptItemRepository.GetByIdAsync(id);

            if (AcquisitionReceiptItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AcquisitionReceiptItemDto = Mapper.Map(AcquisitionReceiptItem);

            return OkResult( CustomMessage.DefaultMessage , AcquisitionReceiptItemDto);

        }
    }
}
