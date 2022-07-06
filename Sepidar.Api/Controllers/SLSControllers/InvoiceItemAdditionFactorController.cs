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

namespace Sepidar.Api.Controllers.InvoiceItemAdditionFactorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceItemAdditionFactorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceItemAdditionFactorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInvoiceItemAdditionFactorCommand command)
        {
            command.Validate();

            var InvoiceItemAdditionFactors = await _unitOfWork.InvoiceItemAdditionFactorRepository.FindAsync(c => c.Id == command.Id);

            if (InvoiceItemAdditionFactors.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInvoiceItemAdditionFactor = Mapper.Map(command);
            await _unitOfWork.InvoiceItemAdditionFactorRepository.AddAsync(newInvoiceItemAdditionFactor);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInvoiceItemAdditionFactorCommand command)
        {

            command.Validate();

            var InvoiceItemAdditionFactor = await _unitOfWork.InvoiceItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InvoiceItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceItemAdditionFactor = Mapper.Map(InvoiceItemAdditionFactor, command);
            InvoiceItemAdditionFactor.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InvoiceItemAdditionFactor = await _unitOfWork.InvoiceItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InvoiceItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InvoiceItemAdditionFactor.IsActive = false;
            InvoiceItemAdditionFactor.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InvoiceItemAdditionFactors = await _unitOfWork.InvoiceItemAdditionFactorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InvoiceItemAdditionFactorsDto = Mapper.Map(InvoiceItemAdditionFactors);

            return OkResult(CustomMessage.DefaultMessage, InvoiceItemAdditionFactorsDto.ToPagingAndSorting(query), InvoiceItemAdditionFactorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InvoiceItemAdditionFactor = await _unitOfWork.InvoiceItemAdditionFactorRepository.GetByIdAsync(id);

            if (InvoiceItemAdditionFactor is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InvoiceItemAdditionFactorDto = Mapper.Map(InvoiceItemAdditionFactor);

            return OkResult( CustomMessage.DefaultMessage , InvoiceItemAdditionFactorDto);

        }
    }
}
