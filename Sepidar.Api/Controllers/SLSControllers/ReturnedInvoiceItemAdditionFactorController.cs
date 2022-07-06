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

namespace Sepidar.Api.Controllers.ReturnedInvoiceItemAdditionFactorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReturnedInvoiceItemAdditionFactorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReturnedInvoiceItemAdditionFactorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReturnedInvoiceItemAdditionFactorCommand command)
        {
            command.Validate();

            var ReturnedInvoiceItemAdditionFactors = await _unitOfWork.ReturnedInvoiceItemAdditionFactorRepository.FindAsync(c => c.Id == command.Id);

            if (ReturnedInvoiceItemAdditionFactors.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReturnedInvoiceItemAdditionFactor = Mapper.Map(command);
            await _unitOfWork.ReturnedInvoiceItemAdditionFactorRepository.AddAsync(newReturnedInvoiceItemAdditionFactor);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReturnedInvoiceItemAdditionFactorCommand command)
        {

            command.Validate();

            var ReturnedInvoiceItemAdditionFactor = await _unitOfWork.ReturnedInvoiceItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoiceItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoiceItemAdditionFactor = Mapper.Map(ReturnedInvoiceItemAdditionFactor, command);
            ReturnedInvoiceItemAdditionFactor.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReturnedInvoiceItemAdditionFactor = await _unitOfWork.ReturnedInvoiceItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReturnedInvoiceItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnedInvoiceItemAdditionFactor.IsActive = false;
            ReturnedInvoiceItemAdditionFactor.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReturnedInvoiceItemAdditionFactors = await _unitOfWork.ReturnedInvoiceItemAdditionFactorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReturnedInvoiceItemAdditionFactorsDto = Mapper.Map(ReturnedInvoiceItemAdditionFactors);

            return OkResult(CustomMessage.DefaultMessage, ReturnedInvoiceItemAdditionFactorsDto.ToPagingAndSorting(query), ReturnedInvoiceItemAdditionFactorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReturnedInvoiceItemAdditionFactor = await _unitOfWork.ReturnedInvoiceItemAdditionFactorRepository.GetByIdAsync(id);

            if (ReturnedInvoiceItemAdditionFactor is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReturnedInvoiceItemAdditionFactorDto = Mapper.Map(ReturnedInvoiceItemAdditionFactor);

            return OkResult( CustomMessage.DefaultMessage , ReturnedInvoiceItemAdditionFactorDto);

        }
    }
}
