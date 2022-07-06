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

namespace Sepidar.Api.Controllers.SalesLimitItemPartyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SalesLimitItemPartyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalesLimitItemPartyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSalesLimitItemPartyCommand command)
        {
            command.Validate();

            var SalesLimitItemPartys = await _unitOfWork.SalesLimitItemPartyRepository.FindAsync(c => c.Id == command.Id);

            if (SalesLimitItemPartys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSalesLimitItemParty = Mapper.Map(command);
            await _unitOfWork.SalesLimitItemPartyRepository.AddAsync(newSalesLimitItemParty);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSalesLimitItemPartyCommand command)
        {

            command.Validate();

            var SalesLimitItemParty = await _unitOfWork.SalesLimitItemPartyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SalesLimitItemParty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SalesLimitItemParty = Mapper.Map(SalesLimitItemParty, command);
            SalesLimitItemParty.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SalesLimitItemParty = await _unitOfWork.SalesLimitItemPartyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SalesLimitItemParty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SalesLimitItemParty.IsActive = false;
            SalesLimitItemParty.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SalesLimitItemPartys = await _unitOfWork.SalesLimitItemPartyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SalesLimitItemPartysDto = Mapper.Map(SalesLimitItemPartys);

            return OkResult(CustomMessage.DefaultMessage, SalesLimitItemPartysDto.ToPagingAndSorting(query), SalesLimitItemPartysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SalesLimitItemParty = await _unitOfWork.SalesLimitItemPartyRepository.GetByIdAsync(id);

            if (SalesLimitItemParty is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SalesLimitItemPartyDto = Mapper.Map(SalesLimitItemParty);

            return OkResult( CustomMessage.DefaultMessage , SalesLimitItemPartyDto);

        }
    }
}
