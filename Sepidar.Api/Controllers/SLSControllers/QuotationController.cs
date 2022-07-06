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

namespace Sepidar.Api.Controllers.QuotationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QuotationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuotationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQuotationCommand command)
        {
            command.Validate();

            var Quotations = await _unitOfWork.QuotationRepository.FindAsync(c => c.Id == command.Id);

            if (Quotations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQuotation = Mapper.Map(command);
            await _unitOfWork.QuotationRepository.AddAsync(newQuotation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQuotationCommand command)
        {

            command.Validate();

            var Quotation = await _unitOfWork.QuotationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Quotation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Quotation = Mapper.Map(Quotation, command);
            Quotation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Quotation = await _unitOfWork.QuotationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Quotation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Quotation.IsActive = false;
            Quotation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Quotations = await _unitOfWork.QuotationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QuotationsDto = Mapper.Map(Quotations);

            return OkResult(CustomMessage.DefaultMessage, QuotationsDto.ToPagingAndSorting(query), QuotationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Quotation = await _unitOfWork.QuotationRepository.GetByIdAsync(id);

            if (Quotation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QuotationDto = Mapper.Map(Quotation);

            return OkResult( CustomMessage.DefaultMessage , QuotationDto);

        }
    }
}
