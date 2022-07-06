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

namespace Sepidar.Api.Controllers.ElementSavedValueControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ElementSavedValueController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ElementSavedValueController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddElementSavedValueCommand command)
        {
            command.Validate();

            var ElementSavedValues = await _unitOfWork.ElementSavedValueRepository.FindAsync(c => c.Id == command.Id);

            if (ElementSavedValues.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newElementSavedValue = Mapper.Map(command);
            await _unitOfWork.ElementSavedValueRepository.AddAsync(newElementSavedValue);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditElementSavedValueCommand command)
        {

            command.Validate();

            var ElementSavedValue = await _unitOfWork.ElementSavedValueRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ElementSavedValue == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElementSavedValue = Mapper.Map(ElementSavedValue, command);
            ElementSavedValue.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ElementSavedValue = await _unitOfWork.ElementSavedValueRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ElementSavedValue == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ElementSavedValue.IsActive = false;
            ElementSavedValue.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ElementSavedValues = await _unitOfWork.ElementSavedValueRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ElementSavedValuesDto = Mapper.Map(ElementSavedValues);

            return OkResult(CustomMessage.DefaultMessage, ElementSavedValuesDto.ToPagingAndSorting(query), ElementSavedValuesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ElementSavedValue = await _unitOfWork.ElementSavedValueRepository.GetByIdAsync(id);

            if (ElementSavedValue is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ElementSavedValueDto = Mapper.Map(ElementSavedValue);

            return OkResult( CustomMessage.DefaultMessage , ElementSavedValueDto);

        }
    }
}
