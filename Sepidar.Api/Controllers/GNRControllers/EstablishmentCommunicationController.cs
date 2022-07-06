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

namespace Sepidar.Api.Controllers.EstablishmentCommunicationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EstablishmentCommunicationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EstablishmentCommunicationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddEstablishmentCommunicationCommand command)
        {
            command.Validate();

            var EstablishmentCommunications = await _unitOfWork.EstablishmentCommunicationRepository.FindAsync(c => c.Id == command.Id);

            if (EstablishmentCommunications.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newEstablishmentCommunication = Mapper.Map(command);
            await _unitOfWork.EstablishmentCommunicationRepository.AddAsync(newEstablishmentCommunication);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditEstablishmentCommunicationCommand command)
        {

            command.Validate();

            var EstablishmentCommunication = await _unitOfWork.EstablishmentCommunicationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (EstablishmentCommunication == null)
                return NotFound(CustomMessage.NotFoundMessage);

            EstablishmentCommunication = Mapper.Map(EstablishmentCommunication, command);
            EstablishmentCommunication.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var EstablishmentCommunication = await _unitOfWork.EstablishmentCommunicationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (EstablishmentCommunication == null)
                return NotFound(CustomMessage.NotFoundMessage);

            EstablishmentCommunication.IsActive = false;
            EstablishmentCommunication.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var EstablishmentCommunications = await _unitOfWork.EstablishmentCommunicationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var EstablishmentCommunicationsDto = Mapper.Map(EstablishmentCommunications);

            return OkResult(CustomMessage.DefaultMessage, EstablishmentCommunicationsDto.ToPagingAndSorting(query), EstablishmentCommunicationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var EstablishmentCommunication = await _unitOfWork.EstablishmentCommunicationRepository.GetByIdAsync(id);

            if (EstablishmentCommunication is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var EstablishmentCommunicationDto = Mapper.Map(EstablishmentCommunication);

            return OkResult( CustomMessage.DefaultMessage , EstablishmentCommunicationDto);

        }
    }
}
