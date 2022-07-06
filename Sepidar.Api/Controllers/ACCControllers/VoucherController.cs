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

namespace Sepidar.Api.Controllers.VoucherControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class VoucherController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public VoucherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddVoucherCommand command)
        {
            command.Validate();

            var Vouchers = await _unitOfWork.VoucherRepository.FindAsync(c => c.Id == command.Id);

            if (Vouchers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newVoucher = Mapper.Map(command);
            await _unitOfWork.VoucherRepository.AddAsync(newVoucher);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditVoucherCommand command)
        {

            command.Validate();

            var Voucher = await _unitOfWork.VoucherRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Voucher == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Voucher = Mapper.Map(Voucher, command);
            Voucher.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Voucher = await _unitOfWork.VoucherRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Voucher == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Voucher.IsActive = false;
            Voucher.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Vouchers = await _unitOfWork.VoucherRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var VouchersDto = Mapper.Map(Vouchers);

            return OkResult(CustomMessage.DefaultMessage, VouchersDto.ToPagingAndSorting(query), VouchersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Voucher = await _unitOfWork.VoucherRepository.GetByIdAsync(id);

            if (Voucher is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var VoucherDto = Mapper.Map(Voucher);

            return OkResult( CustomMessage.DefaultMessage , VoucherDto);

        }
    }
}
