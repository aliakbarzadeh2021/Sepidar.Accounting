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

namespace Sepidar.Api.Controllers.WorkExperienceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WorkExperienceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkExperienceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWorkExperienceCommand command)
        {
            command.Validate();

            var WorkExperiences = await _unitOfWork.WorkExperienceRepository.FindAsync(c => c.Id == command.Id);

            if (WorkExperiences.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWorkExperience = Mapper.Map(command);
            await _unitOfWork.WorkExperienceRepository.AddAsync(newWorkExperience);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWorkExperienceCommand command)
        {

            command.Validate();

            var WorkExperience = await _unitOfWork.WorkExperienceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (WorkExperience == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkExperience = Mapper.Map(WorkExperience, command);
            WorkExperience.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var WorkExperience = await _unitOfWork.WorkExperienceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (WorkExperience == null)
                return NotFound(CustomMessage.NotFoundMessage);

            WorkExperience.IsActive = false;
            WorkExperience.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var WorkExperiences = await _unitOfWork.WorkExperienceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WorkExperiencesDto = Mapper.Map(WorkExperiences);

            return OkResult(CustomMessage.DefaultMessage, WorkExperiencesDto.ToPagingAndSorting(query), WorkExperiencesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var WorkExperience = await _unitOfWork.WorkExperienceRepository.GetByIdAsync(id);

            if (WorkExperience is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WorkExperienceDto = Mapper.Map(WorkExperience);

            return OkResult( CustomMessage.DefaultMessage , WorkExperienceDto);

        }
    }
}
