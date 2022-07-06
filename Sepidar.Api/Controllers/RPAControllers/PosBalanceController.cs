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

namespace Sepidar.Api.Controllers.PosBalanceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PosBalanceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PosBalanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPosBalanceCommand command)
        {
            command.Validate();

            var PosBalances = await _unitOfWork.PosBalanceRepository.FindAsync(c => c.Id == command.Id);

            if (PosBalances.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPosBalance = Mapper.Map(command);
            await _unitOfWork.PosBalanceRepository.AddAsync(newPosBalance);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPosBalanceCommand command)
        {

            command.Validate();

            var PosBalance = await _unitOfWork.PosBalanceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PosBalance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PosBalance = Mapper.Map(PosBalance, command);
            PosBalance.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PosBalance = await _unitOfWork.PosBalanceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PosBalance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PosBalance.IsActive = false;
            PosBalance.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PosBalances = await _unitOfWork.PosBalanceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PosBalancesDto = Mapper.Map(PosBalances);

            return OkResult(CustomMessage.DefaultMessage, PosBalancesDto.ToPagingAndSorting(query), PosBalancesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PosBalance = await _unitOfWork.PosBalanceRepository.GetByIdAsync(id);

            if (PosBalance is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PosBalanceDto = Mapper.Map(PosBalance);

            return OkResult( CustomMessage.DefaultMessage , PosBalanceDto);

        }
    }
}
