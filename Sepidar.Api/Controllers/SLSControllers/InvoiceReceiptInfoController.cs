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

namespace Sepidar.Api.Controllers.InvoiceReceiptInfoControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceReceiptInfoController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceReceiptInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvoiceReceiptInfoCommand command)
        {
            command.Validate();

            var InvoiceReceiptInfos = await _unitOfWork.InvoiceReceiptInfoRepository.FindAsync(c => c.Id == command.Id);

            if (InvoiceReceiptInfos.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvoiceReceiptInfo = Mapper.Map(command);
            await _unitOfWork.InvoiceReceiptInfoRepository.AddAsync(newInvoiceReceiptInfo);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvoiceReceiptInfoCommand command)
        {

            command.Validate();

            var InvoiceReceiptInfo = await _unitOfWork.InvoiceReceiptInfoRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvoiceReceiptInfo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceReceiptInfo = Mapper.Map(InvoiceReceiptInfo, command);
            InvoiceReceiptInfo.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvoiceReceiptInfo = await _unitOfWork.InvoiceReceiptInfoRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvoiceReceiptInfo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceReceiptInfo.IsActive = false;
            InvoiceReceiptInfo.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvoiceReceiptInfos = await _unitOfWork.InvoiceReceiptInfoRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvoiceReceiptInfosDto = Mapper.Map(InvoiceReceiptInfos);

            return OkResult(CustomMessage.DefaultMessage, InvoiceReceiptInfosDto.ToPagingAndSorting(query), InvoiceReceiptInfosDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvoiceReceiptInfo = await _unitOfWork.InvoiceReceiptInfoRepository.GetByIdAsync(id);

            if (InvoiceReceiptInfo is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvoiceReceiptInfoDto = Mapper.Map(InvoiceReceiptInfo);

            return OkResult( CustomMessage.DefaultMessage , InvoiceReceiptInfoDto);

        }
    }
}
