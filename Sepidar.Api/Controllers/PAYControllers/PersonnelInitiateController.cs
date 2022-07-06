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

namespace Sepidar.Api.Controllers.PersonnelInitiateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PersonnelInitiateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PersonnelInitiateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPersonnelInitiateCommand command)
        {
            command.Validate();

            var PersonnelInitiates = await _unitOfWork.PersonnelInitiateRepository.FindAsync(c => c.Id == command.Id);

            if (PersonnelInitiates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPersonnelInitiate = Mapper.Map(command);
            await _unitOfWork.PersonnelInitiateRepository.AddAsync(newPersonnelInitiate);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPersonnelInitiateCommand command)
        {

            command.Validate();

            var PersonnelInitiate = await _unitOfWork.PersonnelInitiateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PersonnelInitiate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PersonnelInitiate = Mapper.Map(PersonnelInitiate, command);
            PersonnelInitiate.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PersonnelInitiate = await _unitOfWork.PersonnelInitiateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PersonnelInitiate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PersonnelInitiate.IsActive = false;
            PersonnelInitiate.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PersonnelInitiates = await _unitOfWork.PersonnelInitiateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PersonnelInitiatesDto = Mapper.Map(PersonnelInitiates);

            return OkResult(CustomMessage.DefaultMessage, PersonnelInitiatesDto.ToPagingAndSorting(query), PersonnelInitiatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PersonnelInitiate = await _unitOfWork.PersonnelInitiateRepository.GetByIdAsync(id);

            if (PersonnelInitiate is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PersonnelInitiateDto = Mapper.Map(PersonnelInitiate);

            return OkResult( CustomMessage.DefaultMessage , PersonnelInitiateDto);

        }
    }
}
