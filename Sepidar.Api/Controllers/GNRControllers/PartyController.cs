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

namespace Sepidar.Api.Controllers.PartyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartyCommand command)
        {
            command.Validate();

            var Partys = await _unitOfWork.PartyRepository.FindAsync(c => c.Id == command.Id);

            if (Partys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newParty = Mapper.Map(command);
            await _unitOfWork.PartyRepository.AddAsync(newParty);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartyCommand command)
        {

            command.Validate();

            var Party = await _unitOfWork.PartyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Party == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Party = Mapper.Map(Party, command);
            Party.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Party = await _unitOfWork.PartyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Party == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Party.IsActive = false;
            Party.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Partys = await _unitOfWork.PartyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartysDto = Mapper.Map(Partys);

            return OkResult(CustomMessage.DefaultMessage, PartysDto.ToPagingAndSorting(query), PartysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Party = await _unitOfWork.PartyRepository.GetByIdAsync(id);

            if (Party is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartyDto = Mapper.Map(Party);

            return OkResult( CustomMessage.DefaultMessage , PartyDto);

        }
    }
}
