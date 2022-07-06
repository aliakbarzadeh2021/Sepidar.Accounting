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

namespace Sepidar.Api.Controllers.PartyOpeningBalanceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PartyOpeningBalanceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartyOpeningBalanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPartyOpeningBalanceCommand command)
        {
            command.Validate();

            var PartyOpeningBalances = await _unitOfWork.PartyOpeningBalanceRepository.FindAsync(c => c.Id == command.Id);

            if (PartyOpeningBalances.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPartyOpeningBalance = Mapper.Map(command);
            await _unitOfWork.PartyOpeningBalanceRepository.AddAsync(newPartyOpeningBalance);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPartyOpeningBalanceCommand command)
        {

            command.Validate();

            var PartyOpeningBalance = await _unitOfWork.PartyOpeningBalanceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PartyOpeningBalance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyOpeningBalance = Mapper.Map(PartyOpeningBalance, command);
            PartyOpeningBalance.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PartyOpeningBalance = await _unitOfWork.PartyOpeningBalanceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PartyOpeningBalance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PartyOpeningBalance.IsActive = false;
            PartyOpeningBalance.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PartyOpeningBalances = await _unitOfWork.PartyOpeningBalanceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PartyOpeningBalancesDto = Mapper.Map(PartyOpeningBalances);

            return OkResult(CustomMessage.DefaultMessage, PartyOpeningBalancesDto.ToPagingAndSorting(query), PartyOpeningBalancesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PartyOpeningBalance = await _unitOfWork.PartyOpeningBalanceRepository.GetByIdAsync(id);

            if (PartyOpeningBalance is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PartyOpeningBalanceDto = Mapper.Map(PartyOpeningBalance);

            return OkResult( CustomMessage.DefaultMessage , PartyOpeningBalanceDto);

        }
    }
}
