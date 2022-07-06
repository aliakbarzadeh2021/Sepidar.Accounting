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

namespace Sepidar.Api.Controllers.CommissionCalculationXMLResultControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionCalculationXMLResultController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommissionCalculationXMLResultController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommissionCalculationXMLResultCommand command)
        {
            command.Validate();

            var CommissionCalculationXMLResults = await _unitOfWork.CommissionCalculationXMLResultRepository.FindAsync(c => c.Id == command.Id);

            if (CommissionCalculationXMLResults.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommissionCalculationXMLResult = Mapper.Map(command);
            await _unitOfWork.CommissionCalculationXMLResultRepository.AddAsync(newCommissionCalculationXMLResult);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommissionCalculationXMLResultCommand command)
        {

            command.Validate();

            var CommissionCalculationXMLResult = await _unitOfWork.CommissionCalculationXMLResultRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommissionCalculationXMLResult == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionCalculationXMLResult = Mapper.Map(CommissionCalculationXMLResult, command);
            CommissionCalculationXMLResult.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommissionCalculationXMLResult = await _unitOfWork.CommissionCalculationXMLResultRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommissionCalculationXMLResult == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionCalculationXMLResult.IsActive = false;
            CommissionCalculationXMLResult.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommissionCalculationXMLResults = await _unitOfWork.CommissionCalculationXMLResultRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommissionCalculationXMLResultsDto = Mapper.Map(CommissionCalculationXMLResults);

            return OkResult(CustomMessage.DefaultMessage, CommissionCalculationXMLResultsDto.ToPagingAndSorting(query), CommissionCalculationXMLResultsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommissionCalculationXMLResult = await _unitOfWork.CommissionCalculationXMLResultRepository.GetByIdAsync(id);

            if (CommissionCalculationXMLResult is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommissionCalculationXMLResultDto = Mapper.Map(CommissionCalculationXMLResult);

            return OkResult( CustomMessage.DefaultMessage , CommissionCalculationXMLResultDto);

        }
    }
}
