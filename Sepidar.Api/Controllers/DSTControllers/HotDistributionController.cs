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

namespace Sepidar.Api.Controllers.HotDistributionControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HotDistributionController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HotDistributionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHotDistributionCommand command)
        {
            command.Validate();

            var HotDistributions = await _unitOfWork.HotDistributionRepository.FindAsync(c => c.Id == command.Id);

            if (HotDistributions.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHotDistribution = Mapper.Map(command);
            await _unitOfWork.HotDistributionRepository.AddAsync(newHotDistribution);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHotDistributionCommand command)
        {

            command.Validate();

            var HotDistribution = await _unitOfWork.HotDistributionRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HotDistribution == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistribution = Mapper.Map(HotDistribution, command);
            HotDistribution.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HotDistribution = await _unitOfWork.HotDistributionRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HotDistribution == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistribution.IsActive = false;
            HotDistribution.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HotDistributions = await _unitOfWork.HotDistributionRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HotDistributionsDto = Mapper.Map(HotDistributions);

            return OkResult(CustomMessage.DefaultMessage, HotDistributionsDto.ToPagingAndSorting(query), HotDistributionsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HotDistribution = await _unitOfWork.HotDistributionRepository.GetByIdAsync(id);

            if (HotDistribution is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HotDistributionDto = Mapper.Map(HotDistribution);

            return OkResult( CustomMessage.DefaultMessage , HotDistributionDto);

        }
    }
}
