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

namespace Sepidar.Api.Controllers.ReturnReasonControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReturnReasonController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReturnReasonController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReturnReasonCommand command)
        {
            command.Validate();

            var ReturnReasons = await _unitOfWork.ReturnReasonRepository.FindAsync(c => c.Id == command.Id);

            if (ReturnReasons.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReturnReason = Mapper.Map(command);
            await _unitOfWork.ReturnReasonRepository.AddAsync(newReturnReason);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReturnReasonCommand command)
        {

            command.Validate();

            var ReturnReason = await _unitOfWork.ReturnReasonRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReturnReason == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnReason = Mapper.Map(ReturnReason, command);
            ReturnReason.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReturnReason = await _unitOfWork.ReturnReasonRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReturnReason == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReturnReason.IsActive = false;
            ReturnReason.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReturnReasons = await _unitOfWork.ReturnReasonRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReturnReasonsDto = Mapper.Map(ReturnReasons);

            return OkResult(CustomMessage.DefaultMessage, ReturnReasonsDto.ToPagingAndSorting(query), ReturnReasonsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReturnReason = await _unitOfWork.ReturnReasonRepository.GetByIdAsync(id);

            if (ReturnReason is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReturnReasonDto = Mapper.Map(ReturnReason);

            return OkResult( CustomMessage.DefaultMessage , ReturnReasonDto);

        }
    }
}
