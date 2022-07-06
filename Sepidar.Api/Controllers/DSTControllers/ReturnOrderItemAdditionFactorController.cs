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

namespace Sepidar.Api.Controllers.ReturnOrderItemAdditionFactorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReturnOrderItemAdditionFactorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReturnOrderItemAdditionFactorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReturnOrderItemAdditionFactorCommand command)
        {
            command.Validate();

            var ReturnOrderItemAdditionFactors = await _unitOfWork.ReturnOrderItemAdditionFactorRepository.FindAsync(c => c.Id == command.Id);

            if (ReturnOrderItemAdditionFactors.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReturnOrderItemAdditionFactor = Mapper.Map(command);
            await _unitOfWork.ReturnOrderItemAdditionFactorRepository.AddAsync(newReturnOrderItemAdditionFactor);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReturnOrderItemAdditionFactorCommand command)
        {

            command.Validate();

            var ReturnOrderItemAdditionFactor = await _unitOfWork.ReturnOrderItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReturnOrderItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnOrderItemAdditionFactor = Mapper.Map(ReturnOrderItemAdditionFactor, command);
            ReturnOrderItemAdditionFactor.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReturnOrderItemAdditionFactor = await _unitOfWork.ReturnOrderItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReturnOrderItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnOrderItemAdditionFactor.IsActive = false;
            ReturnOrderItemAdditionFactor.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReturnOrderItemAdditionFactors = await _unitOfWork.ReturnOrderItemAdditionFactorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReturnOrderItemAdditionFactorsDto = Mapper.Map(ReturnOrderItemAdditionFactors);

            return OkResult(CustomMessage.DefaultMessage, ReturnOrderItemAdditionFactorsDto.ToPagingAndSorting(query), ReturnOrderItemAdditionFactorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReturnOrderItemAdditionFactor = await _unitOfWork.ReturnOrderItemAdditionFactorRepository.GetByIdAsync(id);

            if (ReturnOrderItemAdditionFactor is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReturnOrderItemAdditionFactorDto = Mapper.Map(ReturnOrderItemAdditionFactor);

            return OkResult( CustomMessage.DefaultMessage , ReturnOrderItemAdditionFactorDto);

        }
    }
}
