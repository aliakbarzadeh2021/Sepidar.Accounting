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

namespace Sepidar.Api.Controllers.FormulaElementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class FormulaElementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FormulaElementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddFormulaElementCommand command)
        {
            command.Validate();

            var FormulaElements = await _unitOfWork.FormulaElementRepository.FindAsync(c => c.Id == command.Id);

            if (FormulaElements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newFormulaElement = Mapper.Map(command);
            await _unitOfWork.FormulaElementRepository.AddAsync(newFormulaElement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditFormulaElementCommand command)
        {

            command.Validate();

            var FormulaElement = await _unitOfWork.FormulaElementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (FormulaElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FormulaElement = Mapper.Map(FormulaElement, command);
            FormulaElement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var FormulaElement = await _unitOfWork.FormulaElementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (FormulaElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FormulaElement.IsActive = false;
            FormulaElement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var FormulaElements = await _unitOfWork.FormulaElementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var FormulaElementsDto = Mapper.Map(FormulaElements);

            return OkResult(CustomMessage.DefaultMessage, FormulaElementsDto.ToPagingAndSorting(query), FormulaElementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var FormulaElement = await _unitOfWork.FormulaElementRepository.GetByIdAsync(id);

            if (FormulaElement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var FormulaElementDto = Mapper.Map(FormulaElement);

            return OkResult( CustomMessage.DefaultMessage , FormulaElementDto);

        }
    }
}
