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

namespace Sepidar.Api.Controllers.CommissionCalculationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionCalculationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommissionCalculationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommissionCalculationCommand command)
        {
            command.Validate();

            var CommissionCalculations = await _unitOfWork.CommissionCalculationRepository.FindAsync(c => c.Id == command.Id);

            if (CommissionCalculations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommissionCalculation = Mapper.Map(command);
            await _unitOfWork.CommissionCalculationRepository.AddAsync(newCommissionCalculation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommissionCalculationCommand command)
        {

            command.Validate();

            var CommissionCalculation = await _unitOfWork.CommissionCalculationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommissionCalculation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionCalculation = Mapper.Map(CommissionCalculation, command);
            CommissionCalculation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommissionCalculation = await _unitOfWork.CommissionCalculationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommissionCalculation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionCalculation.IsActive = false;
            CommissionCalculation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommissionCalculations = await _unitOfWork.CommissionCalculationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommissionCalculationsDto = Mapper.Map(CommissionCalculations);

            return OkResult(CustomMessage.DefaultMessage, CommissionCalculationsDto.ToPagingAndSorting(query), CommissionCalculationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommissionCalculation = await _unitOfWork.CommissionCalculationRepository.GetByIdAsync(id);

            if (CommissionCalculation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommissionCalculationDto = Mapper.Map(CommissionCalculation);

            return OkResult( CustomMessage.DefaultMessage , CommissionCalculationDto);

        }
    }
}
