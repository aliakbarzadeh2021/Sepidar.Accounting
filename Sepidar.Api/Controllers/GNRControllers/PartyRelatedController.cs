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

namespace Sepidar.Api.Controllers.PartyRelatedControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartyRelatedController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartyRelatedController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartyRelatedCommand command)
        {
            command.Validate();

            var PartyRelateds = await _unitOfWork.PartyRelatedRepository.FindAsync(c => c.Id == command.Id);

            if (PartyRelateds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartyRelated = Mapper.Map(command);
            await _unitOfWork.PartyRelatedRepository.AddAsync(newPartyRelated);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartyRelatedCommand command)
        {

            command.Validate();

            var PartyRelated = await _unitOfWork.PartyRelatedRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartyRelated == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyRelated = Mapper.Map(PartyRelated, command);
            PartyRelated.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartyRelated = await _unitOfWork.PartyRelatedRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartyRelated == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyRelated.IsActive = false;
            PartyRelated.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartyRelateds = await _unitOfWork.PartyRelatedRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartyRelatedsDto = Mapper.Map(PartyRelateds);

            return OkResult(CustomMessage.DefaultMessage, PartyRelatedsDto.ToPagingAndSorting(query), PartyRelatedsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartyRelated = await _unitOfWork.PartyRelatedRepository.GetByIdAsync(id);

            if (PartyRelated is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartyRelatedDto = Mapper.Map(PartyRelated);

            return OkResult( CustomMessage.DefaultMessage , PartyRelatedDto);

        }
    }
}
