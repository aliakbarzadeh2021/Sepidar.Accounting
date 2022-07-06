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

namespace Sepidar.Api.Controllers.CostStatementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CostStatementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CostStatementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCostStatementCommand command)
        {
            command.Validate();

            var CostStatements = await _unitOfWork.CostStatementRepository.FindAsync(c => c.Id == command.Id);

            if (CostStatements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCostStatement = Mapper.Map(command);
            await _unitOfWork.CostStatementRepository.AddAsync(newCostStatement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCostStatementCommand command)
        {

            command.Validate();

            var CostStatement = await _unitOfWork.CostStatementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CostStatement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostStatement = Mapper.Map(CostStatement, command);
            CostStatement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CostStatement = await _unitOfWork.CostStatementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CostStatement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CostStatement.IsActive = false;
            CostStatement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CostStatements = await _unitOfWork.CostStatementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CostStatementsDto = Mapper.Map(CostStatements);

            return OkResult(CustomMessage.DefaultMessage, CostStatementsDto.ToPagingAndSorting(query), CostStatementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CostStatement = await _unitOfWork.CostStatementRepository.GetByIdAsync(id);

            if (CostStatement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CostStatementDto = Mapper.Map(CostStatement);

            return OkResult( CustomMessage.DefaultMessage , CostStatementDto);

        }
    }
}
