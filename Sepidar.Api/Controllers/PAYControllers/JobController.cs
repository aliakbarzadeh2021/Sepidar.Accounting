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

namespace Sepidar.Api.Controllers.JobControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public JobController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddJobCommand command)
        {
            command.Validate();

            var Jobs = await _unitOfWork.JobRepository.FindAsync(c => c.Id == command.Id);

            if (Jobs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newJob = Mapper.Map(command);
            await _unitOfWork.JobRepository.AddAsync(newJob);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditJobCommand command)
        {

            command.Validate();

            var Job = await _unitOfWork.JobRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Job == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Job = Mapper.Map(Job, command);
            Job.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Job = await _unitOfWork.JobRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Job == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Job.IsActive = false;
            Job.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Jobs = await _unitOfWork.JobRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var JobsDto = Mapper.Map(Jobs);

            return OkResult(CustomMessage.DefaultMessage, JobsDto.ToPagingAndSorting(query), JobsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Job = await _unitOfWork.JobRepository.GetByIdAsync(id);

            if (Job is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var JobDto = Mapper.Map(Job);

            return OkResult( CustomMessage.DefaultMessage , JobDto);

        }
    }
}
