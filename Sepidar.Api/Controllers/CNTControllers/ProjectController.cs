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

namespace Sepidar.Api.Controllers.ProjectControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProjectController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProjectCommand command)
        {
            command.Validate();

            var Projects = await _unitOfWork.ProjectRepository.FindAsync(c => c.Id == command.Id);

            if (Projects.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProject = Mapper.Map(command);
            await _unitOfWork.ProjectRepository.AddAsync(newProject);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProjectCommand command)
        {

            command.Validate();

            var Project = await _unitOfWork.ProjectRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Project == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Project = Mapper.Map(Project, command);
            Project.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Project = await _unitOfWork.ProjectRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Project == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Project.IsActive = false;
            Project.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Projects = await _unitOfWork.ProjectRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProjectsDto = Mapper.Map(Projects);

            return OkResult(CustomMessage.DefaultMessage, ProjectsDto.ToPagingAndSorting(query), ProjectsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Project = await _unitOfWork.ProjectRepository.GetByIdAsync(id);

            if (Project is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProjectDto = Mapper.Map(Project);

            return OkResult( CustomMessage.DefaultMessage , ProjectDto);

        }
    }
}
