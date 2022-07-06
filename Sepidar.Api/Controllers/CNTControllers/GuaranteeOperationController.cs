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

namespace Sepidar.Api.Controllers.GuaranteeOperationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GuaranteeOperationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GuaranteeOperationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGuaranteeOperationCommand command)
        {
            command.Validate();

            var GuaranteeOperations = await _unitOfWork.GuaranteeOperationRepository.FindAsync(c => c.Id == command.Id);

            if (GuaranteeOperations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGuaranteeOperation = Mapper.Map(command);
            await _unitOfWork.GuaranteeOperationRepository.AddAsync(newGuaranteeOperation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGuaranteeOperationCommand command)
        {

            command.Validate();

            var GuaranteeOperation = await _unitOfWork.GuaranteeOperationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GuaranteeOperation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GuaranteeOperation = Mapper.Map(GuaranteeOperation, command);
            GuaranteeOperation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GuaranteeOperation = await _unitOfWork.GuaranteeOperationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GuaranteeOperation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GuaranteeOperation.IsActive = false;
            GuaranteeOperation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GuaranteeOperations = await _unitOfWork.GuaranteeOperationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GuaranteeOperationsDto = Mapper.Map(GuaranteeOperations);

            return OkResult(CustomMessage.DefaultMessage, GuaranteeOperationsDto.ToPagingAndSorting(query), GuaranteeOperationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GuaranteeOperation = await _unitOfWork.GuaranteeOperationRepository.GetByIdAsync(id);

            if (GuaranteeOperation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GuaranteeOperationDto = Mapper.Map(GuaranteeOperation);

            return OkResult( CustomMessage.DefaultMessage , GuaranteeOperationDto);

        }
    }
}
