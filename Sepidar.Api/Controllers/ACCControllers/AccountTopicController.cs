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

namespace Sepidar.Api.Controllers.AccountTopicControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AccountTopicController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountTopicController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAccountTopicCommand command)
        {
            command.Validate();

            var AccountTopics = await _unitOfWork.AccountTopicRepository.FindAsync(c => c.Id == command.Id);

            if (AccountTopics.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAccountTopic = Mapper.Map(command);
            await _unitOfWork.AccountTopicRepository.AddAsync(newAccountTopic);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAccountTopicCommand command)
        {

            command.Validate();

            var AccountTopic = await _unitOfWork.AccountTopicRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AccountTopic == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccountTopic = Mapper.Map(AccountTopic, command);
            AccountTopic.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AccountTopic = await _unitOfWork.AccountTopicRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AccountTopic == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AccountTopic.IsActive = false;
            AccountTopic.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AccountTopics = await _unitOfWork.AccountTopicRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AccountTopicsDto = Mapper.Map(AccountTopics);

            return OkResult(CustomMessage.DefaultMessage, AccountTopicsDto.ToPagingAndSorting(query), AccountTopicsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AccountTopic = await _unitOfWork.AccountTopicRepository.GetByIdAsync(id);

            if (AccountTopic is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AccountTopicDto = Mapper.Map(AccountTopic);

            return OkResult( CustomMessage.DefaultMessage , AccountTopicDto);

        }
    }
}
