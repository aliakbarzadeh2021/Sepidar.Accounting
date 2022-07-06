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

namespace Sepidar.Api.Controllers.OpeningOperationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OpeningOperationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OpeningOperationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOpeningOperationCommand command)
        {
            command.Validate();

            var OpeningOperations = await _unitOfWork.OpeningOperationRepository.FindAsync(c => c.Id == command.Id);

            if (OpeningOperations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newOpeningOperation = Mapper.Map(command);
            await _unitOfWork.OpeningOperationRepository.AddAsync(newOpeningOperation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditOpeningOperationCommand command)
        {

            command.Validate();

            var OpeningOperation = await _unitOfWork.OpeningOperationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (OpeningOperation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OpeningOperation = Mapper.Map(OpeningOperation, command);
            OpeningOperation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var OpeningOperation = await _unitOfWork.OpeningOperationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (OpeningOperation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            OpeningOperation.IsActive = false;
            OpeningOperation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var OpeningOperations = await _unitOfWork.OpeningOperationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var OpeningOperationsDto = Mapper.Map(OpeningOperations);

            return OkResult(CustomMessage.DefaultMessage, OpeningOperationsDto.ToPagingAndSorting(query), OpeningOperationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var OpeningOperation = await _unitOfWork.OpeningOperationRepository.GetByIdAsync(id);

            if (OpeningOperation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var OpeningOperationDto = Mapper.Map(OpeningOperation);

            return OkResult( CustomMessage.DefaultMessage , OpeningOperationDto);

        }
    }
}
