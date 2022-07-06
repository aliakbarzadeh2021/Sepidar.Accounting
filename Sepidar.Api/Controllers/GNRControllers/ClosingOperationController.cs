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

namespace Sepidar.Api.Controllers.ClosingOperationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ClosingOperationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClosingOperationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddClosingOperationCommand command)
        {
            command.Validate();

            var ClosingOperations = await _unitOfWork.ClosingOperationRepository.FindAsync(c => c.Id == command.Id);

            if (ClosingOperations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newClosingOperation = Mapper.Map(command);
            await _unitOfWork.ClosingOperationRepository.AddAsync(newClosingOperation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditClosingOperationCommand command)
        {

            command.Validate();

            var ClosingOperation = await _unitOfWork.ClosingOperationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ClosingOperation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ClosingOperation = Mapper.Map(ClosingOperation, command);
            ClosingOperation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ClosingOperation = await _unitOfWork.ClosingOperationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ClosingOperation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ClosingOperation.IsActive = false;
            ClosingOperation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ClosingOperations = await _unitOfWork.ClosingOperationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ClosingOperationsDto = Mapper.Map(ClosingOperations);

            return OkResult(CustomMessage.DefaultMessage, ClosingOperationsDto.ToPagingAndSorting(query), ClosingOperationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ClosingOperation = await _unitOfWork.ClosingOperationRepository.GetByIdAsync(id);

            if (ClosingOperation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ClosingOperationDto = Mapper.Map(ClosingOperation);

            return OkResult( CustomMessage.DefaultMessage , ClosingOperationDto);

        }
    }
}
