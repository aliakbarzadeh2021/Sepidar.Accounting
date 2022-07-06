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

namespace Sepidar.Api.Controllers.HotDistributionUnexecutedActControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HotDistributionUnexecutedActController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HotDistributionUnexecutedActController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHotDistributionUnexecutedActCommand command)
        {
            command.Validate();

            var HotDistributionUnexecutedActs = await _unitOfWork.HotDistributionUnexecutedActRepository.FindAsync(c => c.Id == command.Id);

            if (HotDistributionUnexecutedActs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHotDistributionUnexecutedAct = Mapper.Map(command);
            await _unitOfWork.HotDistributionUnexecutedActRepository.AddAsync(newHotDistributionUnexecutedAct);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHotDistributionUnexecutedActCommand command)
        {

            command.Validate();

            var HotDistributionUnexecutedAct = await _unitOfWork.HotDistributionUnexecutedActRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HotDistributionUnexecutedAct == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionUnexecutedAct = Mapper.Map(HotDistributionUnexecutedAct, command);
            HotDistributionUnexecutedAct.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HotDistributionUnexecutedAct = await _unitOfWork.HotDistributionUnexecutedActRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HotDistributionUnexecutedAct == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionUnexecutedAct.IsActive = false;
            HotDistributionUnexecutedAct.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HotDistributionUnexecutedActs = await _unitOfWork.HotDistributionUnexecutedActRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HotDistributionUnexecutedActsDto = Mapper.Map(HotDistributionUnexecutedActs);

            return OkResult(CustomMessage.DefaultMessage, HotDistributionUnexecutedActsDto.ToPagingAndSorting(query), HotDistributionUnexecutedActsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HotDistributionUnexecutedAct = await _unitOfWork.HotDistributionUnexecutedActRepository.GetByIdAsync(id);

            if (HotDistributionUnexecutedAct is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HotDistributionUnexecutedActDto = Mapper.Map(HotDistributionUnexecutedAct);

            return OkResult( CustomMessage.DefaultMessage , HotDistributionUnexecutedActDto);

        }
    }
}
