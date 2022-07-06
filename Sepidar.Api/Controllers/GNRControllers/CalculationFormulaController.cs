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

namespace Sepidar.Api.Controllers.CalculationFormulaControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationFormulaController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CalculationFormulaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCalculationFormulaCommand command)
        {
            command.Validate();

            var CalculationFormulas = await _unitOfWork.CalculationFormulaRepository.FindAsync(c => c.Id == command.Id);

            if (CalculationFormulas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCalculationFormula = Mapper.Map(command);
            await _unitOfWork.CalculationFormulaRepository.AddAsync(newCalculationFormula);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCalculationFormulaCommand command)
        {

            command.Validate();

            var CalculationFormula = await _unitOfWork.CalculationFormulaRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CalculationFormula == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CalculationFormula = Mapper.Map(CalculationFormula, command);
            CalculationFormula.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CalculationFormula = await _unitOfWork.CalculationFormulaRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CalculationFormula == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CalculationFormula.IsActive = false;
            CalculationFormula.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CalculationFormulas = await _unitOfWork.CalculationFormulaRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CalculationFormulasDto = Mapper.Map(CalculationFormulas);

            return OkResult(CustomMessage.DefaultMessage, CalculationFormulasDto.ToPagingAndSorting(query), CalculationFormulasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CalculationFormula = await _unitOfWork.CalculationFormulaRepository.GetByIdAsync(id);

            if (CalculationFormula is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CalculationFormulaDto = Mapper.Map(CalculationFormula);

            return OkResult( CustomMessage.DefaultMessage , CalculationFormulaDto);

        }
    }
}
