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

namespace Sepidar.Api.Controllers.GLVoucherItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GLVoucherItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GLVoucherItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGLVoucherItemCommand command)
        {
            command.Validate();

            var GLVoucherItems = await _unitOfWork.GLVoucherItemRepository.FindAsync(c => c.Id == command.Id);

            if (GLVoucherItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGLVoucherItem = Mapper.Map(command);
            await _unitOfWork.GLVoucherItemRepository.AddAsync(newGLVoucherItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGLVoucherItemCommand command)
        {

            command.Validate();

            var GLVoucherItem = await _unitOfWork.GLVoucherItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GLVoucherItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GLVoucherItem = Mapper.Map(GLVoucherItem, command);
            GLVoucherItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GLVoucherItem = await _unitOfWork.GLVoucherItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GLVoucherItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GLVoucherItem.IsActive = false;
            GLVoucherItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GLVoucherItems = await _unitOfWork.GLVoucherItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GLVoucherItemsDto = Mapper.Map(GLVoucherItems);

            return OkResult(CustomMessage.DefaultMessage, GLVoucherItemsDto.ToPagingAndSorting(query), GLVoucherItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GLVoucherItem = await _unitOfWork.GLVoucherItemRepository.GetByIdAsync(id);

            if (GLVoucherItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GLVoucherItemDto = Mapper.Map(GLVoucherItem);

            return OkResult( CustomMessage.DefaultMessage , GLVoucherItemDto);

        }
    }
}
