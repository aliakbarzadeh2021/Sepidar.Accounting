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

namespace Sepidar.Api.Controllers.CalculationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CalculationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCalculationCommand command)
        {
            command.Validate();

            var Calculations = await _unitOfWork.CalculationRepository.FindAsync(c => c.Id == command.Id);

            if (Calculations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCalculation = Mapper.Map(command);
            await _unitOfWork.CalculationRepository.AddAsync(newCalculation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCalculationCommand command)
        {

            command.Validate();

            var Calculation = await _unitOfWork.CalculationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Calculation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Calculation = Mapper.Map(Calculation, command);
            Calculation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Calculation = await _unitOfWork.CalculationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Calculation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Calculation.IsActive = false;
            Calculation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Calculations = await _unitOfWork.CalculationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CalculationsDto = Mapper.Map(Calculations);

            return OkResult(CustomMessage.DefaultMessage, CalculationsDto.ToPagingAndSorting(query), CalculationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Calculation = await _unitOfWork.CalculationRepository.GetByIdAsync(id);

            if (Calculation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CalculationDto = Mapper.Map(Calculation);

            return OkResult( CustomMessage.DefaultMessage , CalculationDto);

        }
    }
}
