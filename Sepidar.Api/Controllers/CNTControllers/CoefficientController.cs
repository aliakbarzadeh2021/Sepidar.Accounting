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

namespace Sepidar.Api.Controllers.CoefficientControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CoefficientController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CoefficientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCoefficientCommand command)
        {
            command.Validate();

            var Coefficients = await _unitOfWork.CoefficientRepository.FindAsync(c => c.Id == command.Id);

            if (Coefficients.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCoefficient = Mapper.Map(command);
            await _unitOfWork.CoefficientRepository.AddAsync(newCoefficient);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCoefficientCommand command)
        {

            command.Validate();

            var Coefficient = await _unitOfWork.CoefficientRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Coefficient == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Coefficient = Mapper.Map(Coefficient, command);
            Coefficient.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Coefficient = await _unitOfWork.CoefficientRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Coefficient == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Coefficient.IsActive = false;
            Coefficient.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Coefficients = await _unitOfWork.CoefficientRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CoefficientsDto = Mapper.Map(Coefficients);

            return OkResult(CustomMessage.DefaultMessage, CoefficientsDto.ToPagingAndSorting(query), CoefficientsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Coefficient = await _unitOfWork.CoefficientRepository.GetByIdAsync(id);

            if (Coefficient is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CoefficientDto = Mapper.Map(Coefficient);

            return OkResult( CustomMessage.DefaultMessage , CoefficientDto);

        }
    }
}
