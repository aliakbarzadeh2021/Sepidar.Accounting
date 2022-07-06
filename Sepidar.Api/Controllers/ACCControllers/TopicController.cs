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

namespace Sepidar.Api.Controllers.TopicControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TopicController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TopicController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTopicCommand command)
        {
            command.Validate();

            var Topics = await _unitOfWork.TopicRepository.FindAsync(c => c.Id == command.Id);

            if (Topics.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTopic = Mapper.Map(command);
            await _unitOfWork.TopicRepository.AddAsync(newTopic);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTopicCommand command)
        {

            command.Validate();

            var Topic = await _unitOfWork.TopicRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Topic == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Topic = Mapper.Map(Topic, command);
            Topic.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Topic = await _unitOfWork.TopicRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Topic == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Topic.IsActive = false;
            Topic.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Topics = await _unitOfWork.TopicRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TopicsDto = Mapper.Map(Topics);

            return OkResult(CustomMessage.DefaultMessage, TopicsDto.ToPagingAndSorting(query), TopicsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Topic = await _unitOfWork.TopicRepository.GetByIdAsync(id);

            if (Topic is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TopicDto = Mapper.Map(Topic);

            return OkResult( CustomMessage.DefaultMessage , TopicDto);

        }
    }
}
