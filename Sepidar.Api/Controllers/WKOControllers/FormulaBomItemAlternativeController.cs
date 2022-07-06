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

namespace Sepidar.Api.Controllers.FormulaBomItemAlternativeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class FormulaBomItemAlternativeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FormulaBomItemAlternativeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddFormulaBomItemAlternativeCommand command)
        {
            command.Validate();

            var FormulaBomItemAlternatives = await _unitOfWork.FormulaBomItemAlternativeRepository.FindAsync(c => c.Id == command.Id);

            if (FormulaBomItemAlternatives.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newFormulaBomItemAlternative = Mapper.Map(command);
            await _unitOfWork.FormulaBomItemAlternativeRepository.AddAsync(newFormulaBomItemAlternative);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditFormulaBomItemAlternativeCommand command)
        {

            command.Validate();

            var FormulaBomItemAlternative = await _unitOfWork.FormulaBomItemAlternativeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (FormulaBomItemAlternative == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FormulaBomItemAlternative = Mapper.Map(FormulaBomItemAlternative, command);
            FormulaBomItemAlternative.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var FormulaBomItemAlternative = await _unitOfWork.FormulaBomItemAlternativeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (FormulaBomItemAlternative == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FormulaBomItemAlternative.IsActive = false;
            FormulaBomItemAlternative.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var FormulaBomItemAlternatives = await _unitOfWork.FormulaBomItemAlternativeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var FormulaBomItemAlternativesDto = Mapper.Map(FormulaBomItemAlternatives);

            return OkResult(CustomMessage.DefaultMessage, FormulaBomItemAlternativesDto.ToPagingAndSorting(query), FormulaBomItemAlternativesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var FormulaBomItemAlternative = await _unitOfWork.FormulaBomItemAlternativeRepository.GetByIdAsync(id);

            if (FormulaBomItemAlternative is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var FormulaBomItemAlternativeDto = Mapper.Map(FormulaBomItemAlternative);

            return OkResult( CustomMessage.DefaultMessage , FormulaBomItemAlternativeDto);

        }
    }
}
