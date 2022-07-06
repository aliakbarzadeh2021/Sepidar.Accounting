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

namespace Sepidar.Api.Controllers.Message1Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class Message1Controller : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public Message1Controller(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMessage1Command command)
        {
            command.Validate();

            var Message1s = await _unitOfWork.Message1Repository.FindAsync(c => c.Id == command.Id);

            if (Message1s.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMessage1 = Mapper.Map(command);
            await _unitOfWork.Message1Repository.AddAsync(newMessage1);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMessage1Command command)
        {

            command.Validate();

            var Message1 = await _unitOfWork.Message1Repository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Message1 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Message1 = Mapper.Map(Message1, command);
            Message1.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Message1 = await _unitOfWork.Message1Repository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Message1 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Message1.IsActive = false;
            Message1.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Message1s = await _unitOfWork.Message1Repository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var Message1sDto = Mapper.Map(Message1s);

            return OkResult(CustomMessage.DefaultMessage, Message1sDto.ToPagingAndSorting(query), Message1sDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Message1 = await _unitOfWork.Message1Repository.GetByIdAsync(id);

            if (Message1 is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var Message1Dto = Mapper.Map(Message1);

            return OkResult( CustomMessage.DefaultMessage , Message1Dto);

        }
    }
}
