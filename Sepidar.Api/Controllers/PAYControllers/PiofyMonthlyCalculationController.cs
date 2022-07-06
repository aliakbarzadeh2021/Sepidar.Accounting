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

namespace Sepidar.Api.Controllers.PiofyMonthlyCalculationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PiofyMonthlyCalculationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PiofyMonthlyCalculationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPiofyMonthlyCalculationCommand command)
        {
            command.Validate();

            var PiofyMonthlyCalculations = await _unitOfWork.PiofyMonthlyCalculationRepository.FindAsync(c => c.Id == command.Id);

            if (PiofyMonthlyCalculations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPiofyMonthlyCalculation = Mapper.Map(command);
            await _unitOfWork.PiofyMonthlyCalculationRepository.AddAsync(newPiofyMonthlyCalculation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPiofyMonthlyCalculationCommand command)
        {

            command.Validate();

            var PiofyMonthlyCalculation = await _unitOfWork.PiofyMonthlyCalculationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PiofyMonthlyCalculation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PiofyMonthlyCalculation = Mapper.Map(PiofyMonthlyCalculation, command);
            PiofyMonthlyCalculation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PiofyMonthlyCalculation = await _unitOfWork.PiofyMonthlyCalculationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PiofyMonthlyCalculation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PiofyMonthlyCalculation.IsActive = false;
            PiofyMonthlyCalculation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PiofyMonthlyCalculations = await _unitOfWork.PiofyMonthlyCalculationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PiofyMonthlyCalculationsDto = Mapper.Map(PiofyMonthlyCalculations);

            return OkResult(CustomMessage.DefaultMessage, PiofyMonthlyCalculationsDto.ToPagingAndSorting(query), PiofyMonthlyCalculationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PiofyMonthlyCalculation = await _unitOfWork.PiofyMonthlyCalculationRepository.GetByIdAsync(id);

            if (PiofyMonthlyCalculation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PiofyMonthlyCalculationDto = Mapper.Map(PiofyMonthlyCalculation);

            return OkResult( CustomMessage.DefaultMessage , PiofyMonthlyCalculationDto);

        }
    }
}
