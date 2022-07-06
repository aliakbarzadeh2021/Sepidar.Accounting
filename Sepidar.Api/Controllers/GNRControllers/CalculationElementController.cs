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

namespace Sepidar.Api.Controllers.CalculationElementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationElementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CalculationElementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCalculationElementCommand command)
        {
            command.Validate();

            var CalculationElements = await _unitOfWork.CalculationElementRepository.FindAsync(c => c.Id == command.Id);

            if (CalculationElements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCalculationElement = Mapper.Map(command);
            await _unitOfWork.CalculationElementRepository.AddAsync(newCalculationElement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCalculationElementCommand command)
        {

            command.Validate();

            var CalculationElement = await _unitOfWork.CalculationElementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CalculationElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CalculationElement = Mapper.Map(CalculationElement, command);
            CalculationElement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CalculationElement = await _unitOfWork.CalculationElementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CalculationElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CalculationElement.IsActive = false;
            CalculationElement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CalculationElements = await _unitOfWork.CalculationElementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CalculationElementsDto = Mapper.Map(CalculationElements);

            return OkResult(CustomMessage.DefaultMessage, CalculationElementsDto.ToPagingAndSorting(query), CalculationElementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CalculationElement = await _unitOfWork.CalculationElementRepository.GetByIdAsync(id);

            if (CalculationElement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CalculationElementDto = Mapper.Map(CalculationElement);

            return OkResult( CustomMessage.DefaultMessage , CalculationElementDto);

        }
    }
}
