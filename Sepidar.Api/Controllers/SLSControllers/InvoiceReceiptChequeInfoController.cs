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

namespace Sepidar.Api.Controllers.InvoiceReceiptChequeInfoControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceReceiptChequeInfoController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceReceiptChequeInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvoiceReceiptChequeInfoCommand command)
        {
            command.Validate();

            var InvoiceReceiptChequeInfos = await _unitOfWork.InvoiceReceiptChequeInfoRepository.FindAsync(c => c.Id == command.Id);

            if (InvoiceReceiptChequeInfos.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvoiceReceiptChequeInfo = Mapper.Map(command);
            await _unitOfWork.InvoiceReceiptChequeInfoRepository.AddAsync(newInvoiceReceiptChequeInfo);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvoiceReceiptChequeInfoCommand command)
        {

            command.Validate();

            var InvoiceReceiptChequeInfo = await _unitOfWork.InvoiceReceiptChequeInfoRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvoiceReceiptChequeInfo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceReceiptChequeInfo = Mapper.Map(InvoiceReceiptChequeInfo, command);
            InvoiceReceiptChequeInfo.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvoiceReceiptChequeInfo = await _unitOfWork.InvoiceReceiptChequeInfoRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvoiceReceiptChequeInfo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceReceiptChequeInfo.IsActive = false;
            InvoiceReceiptChequeInfo.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvoiceReceiptChequeInfos = await _unitOfWork.InvoiceReceiptChequeInfoRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvoiceReceiptChequeInfosDto = Mapper.Map(InvoiceReceiptChequeInfos);

            return OkResult(CustomMessage.DefaultMessage, InvoiceReceiptChequeInfosDto.ToPagingAndSorting(query), InvoiceReceiptChequeInfosDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvoiceReceiptChequeInfo = await _unitOfWork.InvoiceReceiptChequeInfoRepository.GetByIdAsync(id);

            if (InvoiceReceiptChequeInfo is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvoiceReceiptChequeInfoDto = Mapper.Map(InvoiceReceiptChequeInfo);

            return OkResult( CustomMessage.DefaultMessage , InvoiceReceiptChequeInfoDto);

        }
    }
}
