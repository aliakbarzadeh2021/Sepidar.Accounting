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

namespace Sepidar.Api.Controllers.DepreciationRuleControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DepreciationRuleController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepreciationRuleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDepreciationRuleCommand command)
        {
            command.Validate();

            var DepreciationRules = await _unitOfWork.DepreciationRuleRepository.FindAsync(c => c.Id == command.Id);

            if (DepreciationRules.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDepreciationRule = Mapper.Map(command);
            await _unitOfWork.DepreciationRuleRepository.AddAsync(newDepreciationRule);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDepreciationRuleCommand command)
        {

            command.Validate();

            var DepreciationRule = await _unitOfWork.DepreciationRuleRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DepreciationRule == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DepreciationRule = Mapper.Map(DepreciationRule, command);
            DepreciationRule.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DepreciationRule = await _unitOfWork.DepreciationRuleRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DepreciationRule == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DepreciationRule.IsActive = false;
            DepreciationRule.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DepreciationRules = await _unitOfWork.DepreciationRuleRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DepreciationRulesDto = Mapper.Map(DepreciationRules);

            return OkResult(CustomMessage.DefaultMessage, DepreciationRulesDto.ToPagingAndSorting(query), DepreciationRulesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DepreciationRule = await _unitOfWork.DepreciationRuleRepository.GetByIdAsync(id);

            if (DepreciationRule is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DepreciationRuleDto = Mapper.Map(DepreciationRule);

            return OkResult( CustomMessage.DefaultMessage , DepreciationRuleDto);

        }
    }
}
