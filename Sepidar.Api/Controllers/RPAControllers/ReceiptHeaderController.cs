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

namespace Sepidar.Api.Controllers.ReceiptHeaderControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReceiptHeaderController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReceiptHeaderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReceiptHeaderCommand command)
        {
            command.Validate();

            var ReceiptHeaders = await _unitOfWork.ReceiptHeaderRepository.FindAsync(c => c.Id == command.Id);

            if (ReceiptHeaders.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReceiptHeader = Mapper.Map(command);
            await _unitOfWork.ReceiptHeaderRepository.AddAsync(newReceiptHeader);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReceiptHeaderCommand command)
        {

            command.Validate();

            var ReceiptHeader = await _unitOfWork.ReceiptHeaderRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReceiptHeader == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptHeader = Mapper.Map(ReceiptHeader, command);
            ReceiptHeader.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReceiptHeader = await _unitOfWork.ReceiptHeaderRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReceiptHeader == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptHeader.IsActive = false;
            ReceiptHeader.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReceiptHeaders = await _unitOfWork.ReceiptHeaderRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReceiptHeadersDto = Mapper.Map(ReceiptHeaders);

            return OkResult(CustomMessage.DefaultMessage, ReceiptHeadersDto.ToPagingAndSorting(query), ReceiptHeadersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReceiptHeader = await _unitOfWork.ReceiptHeaderRepository.GetByIdAsync(id);

            if (ReceiptHeader is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReceiptHeaderDto = Mapper.Map(ReceiptHeader);

            return OkResult( CustomMessage.DefaultMessage , ReceiptHeaderDto);

        }
    }
}
