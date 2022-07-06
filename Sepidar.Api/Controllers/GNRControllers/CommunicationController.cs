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

namespace Sepidar.Api.Controllers.CommunicationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommunicationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommunicationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommunicationCommand command)
        {
            command.Validate();

            var Communications = await _unitOfWork.CommunicationRepository.FindAsync(c => c.Id == command.Id);

            if (Communications.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommunication = Mapper.Map(command);
            await _unitOfWork.CommunicationRepository.AddAsync(newCommunication);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommunicationCommand command)
        {

            command.Validate();

            var Communication = await _unitOfWork.CommunicationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Communication == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Communication = Mapper.Map(Communication, command);
            Communication.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Communication = await _unitOfWork.CommunicationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Communication == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Communication.IsActive = false;
            Communication.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Communications = await _unitOfWork.CommunicationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommunicationsDto = Mapper.Map(Communications);

            return OkResult(CustomMessage.DefaultMessage, CommunicationsDto.ToPagingAndSorting(query), CommunicationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Communication = await _unitOfWork.CommunicationRepository.GetByIdAsync(id);

            if (Communication is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommunicationDto = Mapper.Map(Communication);

            return OkResult( CustomMessage.DefaultMessage , CommunicationDto);

        }
    }
}
