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

namespace Sepidar.Api.Controllers.CommissionStepControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionStepController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommissionStepController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommissionStepCommand command)
        {
            command.Validate();

            var CommissionSteps = await _unitOfWork.CommissionStepRepository.FindAsync(c => c.Id == command.Id);

            if (CommissionSteps.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommissionStep = Mapper.Map(command);
            await _unitOfWork.CommissionStepRepository.AddAsync(newCommissionStep);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommissionStepCommand command)
        {

            command.Validate();

            var CommissionStep = await _unitOfWork.CommissionStepRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommissionStep == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionStep = Mapper.Map(CommissionStep, command);
            CommissionStep.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommissionStep = await _unitOfWork.CommissionStepRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommissionStep == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionStep.IsActive = false;
            CommissionStep.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommissionSteps = await _unitOfWork.CommissionStepRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommissionStepsDto = Mapper.Map(CommissionSteps);

            return OkResult(CustomMessage.DefaultMessage, CommissionStepsDto.ToPagingAndSorting(query), CommissionStepsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommissionStep = await _unitOfWork.CommissionStepRepository.GetByIdAsync(id);

            if (CommissionStep is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommissionStepDto = Mapper.Map(CommissionStep);

            return OkResult( CustomMessage.DefaultMessage , CommissionStepDto);

        }
    }
}
