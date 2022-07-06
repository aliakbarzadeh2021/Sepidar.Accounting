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

namespace Sepidar.Api.Controllers.ColdDistributionControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ColdDistributionController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ColdDistributionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddColdDistributionCommand command)
        {
            command.Validate();

            var ColdDistributions = await _unitOfWork.ColdDistributionRepository.FindAsync(c => c.Id == command.Id);

            if (ColdDistributions.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newColdDistribution = Mapper.Map(command);
            await _unitOfWork.ColdDistributionRepository.AddAsync(newColdDistribution);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditColdDistributionCommand command)
        {

            command.Validate();

            var ColdDistribution = await _unitOfWork.ColdDistributionRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ColdDistribution == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ColdDistribution = Mapper.Map(ColdDistribution, command);
            ColdDistribution.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ColdDistribution = await _unitOfWork.ColdDistributionRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ColdDistribution == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ColdDistribution.IsActive = false;
            ColdDistribution.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ColdDistributions = await _unitOfWork.ColdDistributionRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ColdDistributionsDto = Mapper.Map(ColdDistributions);

            return OkResult(CustomMessage.DefaultMessage, ColdDistributionsDto.ToPagingAndSorting(query), ColdDistributionsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ColdDistribution = await _unitOfWork.ColdDistributionRepository.GetByIdAsync(id);

            if (ColdDistribution is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ColdDistributionDto = Mapper.Map(ColdDistribution);

            return OkResult( CustomMessage.DefaultMessage , ColdDistributionDto);

        }
    }
}
