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

namespace Sepidar.Api.Controllers.CommissionBrokerControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionBrokerController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommissionBrokerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommissionBrokerCommand command)
        {
            command.Validate();

            var CommissionBrokers = await _unitOfWork.CommissionBrokerRepository.FindAsync(c => c.Id == command.Id);

            if (CommissionBrokers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommissionBroker = Mapper.Map(command);
            await _unitOfWork.CommissionBrokerRepository.AddAsync(newCommissionBroker);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommissionBrokerCommand command)
        {

            command.Validate();

            var CommissionBroker = await _unitOfWork.CommissionBrokerRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommissionBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionBroker = Mapper.Map(CommissionBroker, command);
            CommissionBroker.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommissionBroker = await _unitOfWork.CommissionBrokerRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommissionBroker == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionBroker.IsActive = false;
            CommissionBroker.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommissionBrokers = await _unitOfWork.CommissionBrokerRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommissionBrokersDto = Mapper.Map(CommissionBrokers);

            return OkResult(CustomMessage.DefaultMessage, CommissionBrokersDto.ToPagingAndSorting(query), CommissionBrokersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommissionBroker = await _unitOfWork.CommissionBrokerRepository.GetByIdAsync(id);

            if (CommissionBroker is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommissionBrokerDto = Mapper.Map(CommissionBroker);

            return OkResult( CustomMessage.DefaultMessage , CommissionBrokerDto);

        }
    }
}
