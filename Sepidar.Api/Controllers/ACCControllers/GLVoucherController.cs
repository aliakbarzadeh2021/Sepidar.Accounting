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

namespace Sepidar.Api.Controllers.GLVoucherControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GLVoucherController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GLVoucherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGLVoucherCommand command)
        {
            command.Validate();

            var GLVouchers = await _unitOfWork.GLVoucherRepository.FindAsync(c => c.Id == command.Id);

            if (GLVouchers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGLVoucher = Mapper.Map(command);
            await _unitOfWork.GLVoucherRepository.AddAsync(newGLVoucher);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGLVoucherCommand command)
        {

            command.Validate();

            var GLVoucher = await _unitOfWork.GLVoucherRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GLVoucher == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GLVoucher = Mapper.Map(GLVoucher, command);
            GLVoucher.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GLVoucher = await _unitOfWork.GLVoucherRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GLVoucher == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GLVoucher.IsActive = false;
            GLVoucher.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GLVouchers = await _unitOfWork.GLVoucherRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GLVouchersDto = Mapper.Map(GLVouchers);

            return OkResult(CustomMessage.DefaultMessage, GLVouchersDto.ToPagingAndSorting(query), GLVouchersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GLVoucher = await _unitOfWork.GLVoucherRepository.GetByIdAsync(id);

            if (GLVoucher is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GLVoucherDto = Mapper.Map(GLVoucher);

            return OkResult( CustomMessage.DefaultMessage , GLVoucherDto);

        }
    }
}
