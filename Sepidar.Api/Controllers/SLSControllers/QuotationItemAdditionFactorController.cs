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

namespace Sepidar.Api.Controllers.QuotationItemAdditionFactorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QuotationItemAdditionFactorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuotationItemAdditionFactorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQuotationItemAdditionFactorCommand command)
        {
            command.Validate();

            var QuotationItemAdditionFactors = await _unitOfWork.QuotationItemAdditionFactorRepository.FindAsync(c => c.Id == command.Id);

            if (QuotationItemAdditionFactors.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQuotationItemAdditionFactor = Mapper.Map(command);
            await _unitOfWork.QuotationItemAdditionFactorRepository.AddAsync(newQuotationItemAdditionFactor);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQuotationItemAdditionFactorCommand command)
        {

            command.Validate();

            var QuotationItemAdditionFactor = await _unitOfWork.QuotationItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QuotationItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuotationItemAdditionFactor = Mapper.Map(QuotationItemAdditionFactor, command);
            QuotationItemAdditionFactor.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QuotationItemAdditionFactor = await _unitOfWork.QuotationItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QuotationItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuotationItemAdditionFactor.IsActive = false;
            QuotationItemAdditionFactor.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QuotationItemAdditionFactors = await _unitOfWork.QuotationItemAdditionFactorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QuotationItemAdditionFactorsDto = Mapper.Map(QuotationItemAdditionFactors);

            return OkResult(CustomMessage.DefaultMessage, QuotationItemAdditionFactorsDto.ToPagingAndSorting(query), QuotationItemAdditionFactorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QuotationItemAdditionFactor = await _unitOfWork.QuotationItemAdditionFactorRepository.GetByIdAsync(id);

            if (QuotationItemAdditionFactor is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QuotationItemAdditionFactorDto = Mapper.Map(QuotationItemAdditionFactor);

            return OkResult( CustomMessage.DefaultMessage , QuotationItemAdditionFactorDto);

        }
    }
}
