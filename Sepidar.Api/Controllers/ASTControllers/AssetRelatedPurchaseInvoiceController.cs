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

namespace Sepidar.Api.Controllers.AssetRelatedPurchaseInvoiceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AssetRelatedPurchaseInvoiceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssetRelatedPurchaseInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAssetRelatedPurchaseInvoiceCommand command)
        {
            command.Validate();

            var AssetRelatedPurchaseInvoices = await _unitOfWork.AssetRelatedPurchaseInvoiceRepository.FindAsync(c => c.Id == command.Id);

            if (AssetRelatedPurchaseInvoices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAssetRelatedPurchaseInvoice = Mapper.Map(command);
            await _unitOfWork.AssetRelatedPurchaseInvoiceRepository.AddAsync(newAssetRelatedPurchaseInvoice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAssetRelatedPurchaseInvoiceCommand command)
        {

            command.Validate();

            var AssetRelatedPurchaseInvoice = await _unitOfWork.AssetRelatedPurchaseInvoiceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AssetRelatedPurchaseInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AssetRelatedPurchaseInvoice = Mapper.Map(AssetRelatedPurchaseInvoice, command);
            AssetRelatedPurchaseInvoice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AssetRelatedPurchaseInvoice = await _unitOfWork.AssetRelatedPurchaseInvoiceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AssetRelatedPurchaseInvoice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AssetRelatedPurchaseInvoice.IsActive = false;
            AssetRelatedPurchaseInvoice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AssetRelatedPurchaseInvoices = await _unitOfWork.AssetRelatedPurchaseInvoiceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AssetRelatedPurchaseInvoicesDto = Mapper.Map(AssetRelatedPurchaseInvoices);

            return OkResult(CustomMessage.DefaultMessage, AssetRelatedPurchaseInvoicesDto.ToPagingAndSorting(query), AssetRelatedPurchaseInvoicesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AssetRelatedPurchaseInvoice = await _unitOfWork.AssetRelatedPurchaseInvoiceRepository.GetByIdAsync(id);

            if (AssetRelatedPurchaseInvoice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AssetRelatedPurchaseInvoiceDto = Mapper.Map(AssetRelatedPurchaseInvoice);

            return OkResult( CustomMessage.DefaultMessage , AssetRelatedPurchaseInvoiceDto);

        }
    }
}
