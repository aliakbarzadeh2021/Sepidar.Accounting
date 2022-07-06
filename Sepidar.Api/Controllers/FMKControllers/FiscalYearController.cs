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

namespace Sepidar.Api.Controllers.FiscalYearControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class FiscalYearController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FiscalYearController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddFiscalYearCommand command)
        {
            command.Validate();

            var FiscalYears = await _unitOfWork.FiscalYearRepository.FindAsync(c => c.Id == command.Id);

            if (FiscalYears.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newFiscalYear = Mapper.Map(command);
            await _unitOfWork.FiscalYearRepository.AddAsync(newFiscalYear);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditFiscalYearCommand command)
        {

            command.Validate();

            var FiscalYear = await _unitOfWork.FiscalYearRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (FiscalYear == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FiscalYear = Mapper.Map(FiscalYear, command);
            FiscalYear.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var FiscalYear = await _unitOfWork.FiscalYearRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (FiscalYear == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FiscalYear.IsActive = false;
            FiscalYear.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var FiscalYears = await _unitOfWork.FiscalYearRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var FiscalYearsDto = Mapper.Map(FiscalYears);

            return OkResult(CustomMessage.DefaultMessage, FiscalYearsDto.ToPagingAndSorting(query), FiscalYearsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var FiscalYear = await _unitOfWork.FiscalYearRepository.GetByIdAsync(id);

            if (FiscalYear is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var FiscalYearDto = Mapper.Map(FiscalYear);

            return OkResult( CustomMessage.DefaultMessage , FiscalYearDto);

        }
    }
}
