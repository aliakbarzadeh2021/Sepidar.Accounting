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

namespace Sepidar.Api.Controllers.LookupControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LookupController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public LookupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddLookupCommand command)
        {
            command.Validate();

            var Lookups = await _unitOfWork.LookupRepository.FindAsync(c => c.Id == command.Id);

            if (Lookups.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newLookup = Mapper.Map(command);
            await _unitOfWork.LookupRepository.AddAsync(newLookup);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditLookupCommand command)
        {

            command.Validate();

            var Lookup = await _unitOfWork.LookupRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Lookup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Lookup = Mapper.Map(Lookup, command);
            Lookup.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Lookup = await _unitOfWork.LookupRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Lookup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Lookup.IsActive = false;
            Lookup.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Lookups = await _unitOfWork.LookupRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var LookupsDto = Mapper.Map(Lookups);

            return OkResult(CustomMessage.DefaultMessage, LookupsDto.ToPagingAndSorting(query), LookupsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Lookup = await _unitOfWork.LookupRepository.GetByIdAsync(id);

            if (Lookup is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var LookupDto = Mapper.Map(Lookup);

            return OkResult( CustomMessage.DefaultMessage , LookupDto);

        }
    }
}
