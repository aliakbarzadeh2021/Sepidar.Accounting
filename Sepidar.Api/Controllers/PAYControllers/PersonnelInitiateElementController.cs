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

namespace Sepidar.Api.Controllers.PersonnelInitiateElementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PersonnelInitiateElementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PersonnelInitiateElementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPersonnelInitiateElementCommand command)
        {
            command.Validate();

            var PersonnelInitiateElements = await _unitOfWork.PersonnelInitiateElementRepository.FindAsync(c => c.Id == command.Id);

            if (PersonnelInitiateElements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPersonnelInitiateElement = Mapper.Map(command);
            await _unitOfWork.PersonnelInitiateElementRepository.AddAsync(newPersonnelInitiateElement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPersonnelInitiateElementCommand command)
        {

            command.Validate();

            var PersonnelInitiateElement = await _unitOfWork.PersonnelInitiateElementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PersonnelInitiateElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PersonnelInitiateElement = Mapper.Map(PersonnelInitiateElement, command);
            PersonnelInitiateElement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PersonnelInitiateElement = await _unitOfWork.PersonnelInitiateElementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PersonnelInitiateElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PersonnelInitiateElement.IsActive = false;
            PersonnelInitiateElement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PersonnelInitiateElements = await _unitOfWork.PersonnelInitiateElementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PersonnelInitiateElementsDto = Mapper.Map(PersonnelInitiateElements);

            return OkResult(CustomMessage.DefaultMessage, PersonnelInitiateElementsDto.ToPagingAndSorting(query), PersonnelInitiateElementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PersonnelInitiateElement = await _unitOfWork.PersonnelInitiateElementRepository.GetByIdAsync(id);

            if (PersonnelInitiateElement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PersonnelInitiateElementDto = Mapper.Map(PersonnelInitiateElement);

            return OkResult( CustomMessage.DefaultMessage , PersonnelInitiateElementDto);

        }
    }
}
