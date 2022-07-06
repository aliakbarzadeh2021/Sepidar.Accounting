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

namespace Sepidar.Api.Controllers.TaxTableControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TaxTableController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TaxTableController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTaxTableCommand command)
        {
            command.Validate();

            var TaxTables = await _unitOfWork.TaxTableRepository.FindAsync(c => c.Id == command.Id);

            if (TaxTables.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTaxTable = Mapper.Map(command);
            await _unitOfWork.TaxTableRepository.AddAsync(newTaxTable);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTaxTableCommand command)
        {

            command.Validate();

            var TaxTable = await _unitOfWork.TaxTableRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TaxTable == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TaxTable = Mapper.Map(TaxTable, command);
            TaxTable.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TaxTable = await _unitOfWork.TaxTableRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TaxTable == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TaxTable.IsActive = false;
            TaxTable.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TaxTables = await _unitOfWork.TaxTableRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TaxTablesDto = Mapper.Map(TaxTables);

            return OkResult(CustomMessage.DefaultMessage, TaxTablesDto.ToPagingAndSorting(query), TaxTablesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TaxTable = await _unitOfWork.TaxTableRepository.GetByIdAsync(id);

            if (TaxTable is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TaxTableDto = Mapper.Map(TaxTable);

            return OkResult( CustomMessage.DefaultMessage , TaxTableDto);

        }
    }
}
