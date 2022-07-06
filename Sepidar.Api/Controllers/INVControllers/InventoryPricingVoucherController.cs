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

namespace Sepidar.Api.Controllers.InventoryPricingVoucherControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryPricingVoucherController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryPricingVoucherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryPricingVoucherCommand command)
        {
            command.Validate();

            var InventoryPricingVouchers = await _unitOfWork.InventoryPricingVoucherRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryPricingVouchers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryPricingVoucher = Mapper.Map(command);
            await _unitOfWork.InventoryPricingVoucherRepository.AddAsync(newInventoryPricingVoucher);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryPricingVoucherCommand command)
        {

            command.Validate();

            var InventoryPricingVoucher = await _unitOfWork.InventoryPricingVoucherRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryPricingVoucher == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPricingVoucher = Mapper.Map(InventoryPricingVoucher, command);
            InventoryPricingVoucher.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryPricingVoucher = await _unitOfWork.InventoryPricingVoucherRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryPricingVoucher == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryPricingVoucher.IsActive = false;
            InventoryPricingVoucher.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryPricingVouchers = await _unitOfWork.InventoryPricingVoucherRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryPricingVouchersDto = Mapper.Map(InventoryPricingVouchers);

            return OkResult(CustomMessage.DefaultMessage, InventoryPricingVouchersDto.ToPagingAndSorting(query), InventoryPricingVouchersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryPricingVoucher = await _unitOfWork.InventoryPricingVoucherRepository.GetByIdAsync(id);

            if (InventoryPricingVoucher is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryPricingVoucherDto = Mapper.Map(InventoryPricingVoucher);

            return OkResult( CustomMessage.DefaultMessage , InventoryPricingVoucherDto);

        }
    }
}
