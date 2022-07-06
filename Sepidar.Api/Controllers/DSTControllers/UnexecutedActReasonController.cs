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

namespace Sepidar.Api.Controllers.UnexecutedActReasonControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UnexecutedActReasonController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UnexecutedActReasonController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUnexecutedActReasonCommand command)
        {
            command.Validate();

            var UnexecutedActReasons = await _unitOfWork.UnexecutedActReasonRepository.FindAsync(c => c.Id == command.Id);

            if (UnexecutedActReasons.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUnexecutedActReason = Mapper.Map(command);
            await _unitOfWork.UnexecutedActReasonRepository.AddAsync(newUnexecutedActReason);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUnexecutedActReasonCommand command)
        {

            command.Validate();

            var UnexecutedActReason = await _unitOfWork.UnexecutedActReasonRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UnexecutedActReason == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UnexecutedActReason = Mapper.Map(UnexecutedActReason, command);
            UnexecutedActReason.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UnexecutedActReason = await _unitOfWork.UnexecutedActReasonRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UnexecutedActReason == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UnexecutedActReason.IsActive = false;
            UnexecutedActReason.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UnexecutedActReasons = await _unitOfWork.UnexecutedActReasonRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UnexecutedActReasonsDto = Mapper.Map(UnexecutedActReasons);

            return OkResult(CustomMessage.DefaultMessage, UnexecutedActReasonsDto.ToPagingAndSorting(query), UnexecutedActReasonsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UnexecutedActReason = await _unitOfWork.UnexecutedActReasonRepository.GetByIdAsync(id);

            if (UnexecutedActReason is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UnexecutedActReasonDto = Mapper.Map(UnexecutedActReason);

            return OkResult( CustomMessage.DefaultMessage , UnexecutedActReasonDto);

        }
    }
}
