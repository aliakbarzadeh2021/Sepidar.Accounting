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

namespace Sepidar.Api.Controllers.AcquisitionReceiptControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AcquisitionReceiptController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AcquisitionReceiptController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAcquisitionReceiptCommand command)
        {
            command.Validate();

            var AcquisitionReceipts = await _unitOfWork.AcquisitionReceiptRepository.FindAsync(c => c.Id == command.Id);

            if (AcquisitionReceipts.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAcquisitionReceipt = Mapper.Map(command);
            await _unitOfWork.AcquisitionReceiptRepository.AddAsync(newAcquisitionReceipt);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAcquisitionReceiptCommand command)
        {

            command.Validate();

            var AcquisitionReceipt = await _unitOfWork.AcquisitionReceiptRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AcquisitionReceipt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AcquisitionReceipt = Mapper.Map(AcquisitionReceipt, command);
            AcquisitionReceipt.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AcquisitionReceipt = await _unitOfWork.AcquisitionReceiptRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AcquisitionReceipt == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AcquisitionReceipt.IsActive = false;
            AcquisitionReceipt.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AcquisitionReceipts = await _unitOfWork.AcquisitionReceiptRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AcquisitionReceiptsDto = Mapper.Map(AcquisitionReceipts);

            return OkResult(CustomMessage.DefaultMessage, AcquisitionReceiptsDto.ToPagingAndSorting(query), AcquisitionReceiptsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AcquisitionReceipt = await _unitOfWork.AcquisitionReceiptRepository.GetByIdAsync(id);

            if (AcquisitionReceipt is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AcquisitionReceiptDto = Mapper.Map(AcquisitionReceipt);

            return OkResult( CustomMessage.DefaultMessage , AcquisitionReceiptDto);

        }
    }
}
