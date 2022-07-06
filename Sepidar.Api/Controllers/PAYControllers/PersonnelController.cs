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

namespace Sepidar.Api.Controllers.PersonnelControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PersonnelController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PersonnelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPersonnelCommand command)
        {
            command.Validate();

            var Personnels = await _unitOfWork.PersonnelRepository.FindAsync(c => c.Id == command.Id);

            if (Personnels.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPersonnel = Mapper.Map(command);
            await _unitOfWork.PersonnelRepository.AddAsync(newPersonnel);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPersonnelCommand command)
        {

            command.Validate();

            var Personnel = await _unitOfWork.PersonnelRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Personnel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Personnel = Mapper.Map(Personnel, command);
            Personnel.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Personnel = await _unitOfWork.PersonnelRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Personnel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Personnel.IsActive = false;
            Personnel.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Personnels = await _unitOfWork.PersonnelRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PersonnelsDto = Mapper.Map(Personnels);

            return OkResult(CustomMessage.DefaultMessage, PersonnelsDto.ToPagingAndSorting(query), PersonnelsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Personnel = await _unitOfWork.PersonnelRepository.GetByIdAsync(id);

            if (Personnel is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PersonnelDto = Mapper.Map(Personnel);

            return OkResult( CustomMessage.DefaultMessage , PersonnelDto);

        }
    }
}
