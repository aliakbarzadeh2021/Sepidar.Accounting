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

namespace Sepidar.Api.Controllers.PathPartyAddressControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PathPartyAddressController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PathPartyAddressController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPathPartyAddressCommand command)
        {
            command.Validate();

            var PathPartyAddresss = await _unitOfWork.PathPartyAddressRepository.FindAsync(c => c.Id == command.Id);

            if (PathPartyAddresss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPathPartyAddress = Mapper.Map(command);
            await _unitOfWork.PathPartyAddressRepository.AddAsync(newPathPartyAddress);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPathPartyAddressCommand command)
        {

            command.Validate();

            var PathPartyAddress = await _unitOfWork.PathPartyAddressRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PathPartyAddress == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PathPartyAddress = Mapper.Map(PathPartyAddress, command);
            PathPartyAddress.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PathPartyAddress = await _unitOfWork.PathPartyAddressRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PathPartyAddress == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PathPartyAddress.IsActive = false;
            PathPartyAddress.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PathPartyAddresss = await _unitOfWork.PathPartyAddressRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PathPartyAddresssDto = Mapper.Map(PathPartyAddresss);

            return OkResult(CustomMessage.DefaultMessage, PathPartyAddresssDto.ToPagingAndSorting(query), PathPartyAddresssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PathPartyAddress = await _unitOfWork.PathPartyAddressRepository.GetByIdAsync(id);

            if (PathPartyAddress is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PathPartyAddressDto = Mapper.Map(PathPartyAddress);

            return OkResult( CustomMessage.DefaultMessage , PathPartyAddressDto);

        }
    }
}
