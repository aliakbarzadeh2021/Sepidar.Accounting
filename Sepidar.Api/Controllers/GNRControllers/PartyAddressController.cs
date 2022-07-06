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

namespace Sepidar.Api.Controllers.PartyAddressControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartyAddressController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartyAddressController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartyAddressCommand command)
        {
            command.Validate();

            var PartyAddresss = await _unitOfWork.PartyAddressRepository.FindAsync(c => c.Id == command.Id);

            if (PartyAddresss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartyAddress = Mapper.Map(command);
            await _unitOfWork.PartyAddressRepository.AddAsync(newPartyAddress);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartyAddressCommand command)
        {

            command.Validate();

            var PartyAddress = await _unitOfWork.PartyAddressRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartyAddress == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyAddress = Mapper.Map(PartyAddress, command);
            PartyAddress.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartyAddress = await _unitOfWork.PartyAddressRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartyAddress == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyAddress.IsActive = false;
            PartyAddress.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartyAddresss = await _unitOfWork.PartyAddressRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartyAddresssDto = Mapper.Map(PartyAddresss);

            return OkResult(CustomMessage.DefaultMessage, PartyAddresssDto.ToPagingAndSorting(query), PartyAddresssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartyAddress = await _unitOfWork.PartyAddressRepository.GetByIdAsync(id);

            if (PartyAddress is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartyAddressDto = Mapper.Map(PartyAddress);

            return OkResult( CustomMessage.DefaultMessage , PartyAddressDto);

        }
    }
}
