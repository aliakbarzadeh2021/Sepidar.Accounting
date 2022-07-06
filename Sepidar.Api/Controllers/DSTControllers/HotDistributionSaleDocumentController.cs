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

namespace Sepidar.Api.Controllers.HotDistributionSaleDocumentControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HotDistributionSaleDocumentController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HotDistributionSaleDocumentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHotDistributionSaleDocumentCommand command)
        {
            command.Validate();

            var HotDistributionSaleDocuments = await _unitOfWork.HotDistributionSaleDocumentRepository.FindAsync(c => c.Id == command.Id);

            if (HotDistributionSaleDocuments.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHotDistributionSaleDocument = Mapper.Map(command);
            await _unitOfWork.HotDistributionSaleDocumentRepository.AddAsync(newHotDistributionSaleDocument);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHotDistributionSaleDocumentCommand command)
        {

            command.Validate();

            var HotDistributionSaleDocument = await _unitOfWork.HotDistributionSaleDocumentRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HotDistributionSaleDocument == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionSaleDocument = Mapper.Map(HotDistributionSaleDocument, command);
            HotDistributionSaleDocument.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HotDistributionSaleDocument = await _unitOfWork.HotDistributionSaleDocumentRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HotDistributionSaleDocument == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionSaleDocument.IsActive = false;
            HotDistributionSaleDocument.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HotDistributionSaleDocuments = await _unitOfWork.HotDistributionSaleDocumentRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HotDistributionSaleDocumentsDto = Mapper.Map(HotDistributionSaleDocuments);

            return OkResult(CustomMessage.DefaultMessage, HotDistributionSaleDocumentsDto.ToPagingAndSorting(query), HotDistributionSaleDocumentsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HotDistributionSaleDocument = await _unitOfWork.HotDistributionSaleDocumentRepository.GetByIdAsync(id);

            if (HotDistributionSaleDocument is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HotDistributionSaleDocumentDto = Mapper.Map(HotDistributionSaleDocument);

            return OkResult( CustomMessage.DefaultMessage , HotDistributionSaleDocumentDto);

        }
    }
}
