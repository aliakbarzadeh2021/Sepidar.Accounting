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

namespace Sepidar.Api.Controllers.VoucherItemTrackingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class VoucherItemTrackingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public VoucherItemTrackingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddVoucherItemTrackingCommand command)
        {
            command.Validate();

            var VoucherItemTrackings = await _unitOfWork.VoucherItemTrackingRepository.FindAsync(c => c.Id == command.Id);

            if (VoucherItemTrackings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newVoucherItemTracking = Mapper.Map(command);
            await _unitOfWork.VoucherItemTrackingRepository.AddAsync(newVoucherItemTracking);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditVoucherItemTrackingCommand command)
        {

            command.Validate();

            var VoucherItemTracking = await _unitOfWork.VoucherItemTrackingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (VoucherItemTracking == null)
                return NotFound(CustomMessage.NotFoundMessage);

            VoucherItemTracking = Mapper.Map(VoucherItemTracking, command);
            VoucherItemTracking.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var VoucherItemTracking = await _unitOfWork.VoucherItemTrackingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (VoucherItemTracking == null)
                return NotFound(CustomMessage.NotFoundMessage);

            VoucherItemTracking.IsActive = false;
            VoucherItemTracking.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var VoucherItemTrackings = await _unitOfWork.VoucherItemTrackingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var VoucherItemTrackingsDto = Mapper.Map(VoucherItemTrackings);

            return OkResult(CustomMessage.DefaultMessage, VoucherItemTrackingsDto.ToPagingAndSorting(query), VoucherItemTrackingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var VoucherItemTracking = await _unitOfWork.VoucherItemTrackingRepository.GetByIdAsync(id);

            if (VoucherItemTracking is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var VoucherItemTrackingDto = Mapper.Map(VoucherItemTracking);

            return OkResult( CustomMessage.DefaultMessage , VoucherItemTrackingDto);

        }
    }
}
