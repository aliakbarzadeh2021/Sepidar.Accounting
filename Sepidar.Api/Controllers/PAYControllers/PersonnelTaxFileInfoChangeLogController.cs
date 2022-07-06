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

namespace Sepidar.Api.Controllers.PersonnelTaxFileInfoChangeLogControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PersonnelTaxFileInfoChangeLogController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PersonnelTaxFileInfoChangeLogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPersonnelTaxFileInfoChangeLogCommand command)
        {
            command.Validate();

            var PersonnelTaxFileInfoChangeLogs = await _unitOfWork.PersonnelTaxFileInfoChangeLogRepository.FindAsync(c => c.Id == command.Id);

            if (PersonnelTaxFileInfoChangeLogs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPersonnelTaxFileInfoChangeLog = Mapper.Map(command);
            await _unitOfWork.PersonnelTaxFileInfoChangeLogRepository.AddAsync(newPersonnelTaxFileInfoChangeLog);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPersonnelTaxFileInfoChangeLogCommand command)
        {

            command.Validate();

            var PersonnelTaxFileInfoChangeLog = await _unitOfWork.PersonnelTaxFileInfoChangeLogRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PersonnelTaxFileInfoChangeLog == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PersonnelTaxFileInfoChangeLog = Mapper.Map(PersonnelTaxFileInfoChangeLog, command);
            PersonnelTaxFileInfoChangeLog.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PersonnelTaxFileInfoChangeLog = await _unitOfWork.PersonnelTaxFileInfoChangeLogRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PersonnelTaxFileInfoChangeLog == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PersonnelTaxFileInfoChangeLog.IsActive = false;
            PersonnelTaxFileInfoChangeLog.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PersonnelTaxFileInfoChangeLogs = await _unitOfWork.PersonnelTaxFileInfoChangeLogRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PersonnelTaxFileInfoChangeLogsDto = Mapper.Map(PersonnelTaxFileInfoChangeLogs);

            return OkResult(CustomMessage.DefaultMessage, PersonnelTaxFileInfoChangeLogsDto.ToPagingAndSorting(query), PersonnelTaxFileInfoChangeLogsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PersonnelTaxFileInfoChangeLog = await _unitOfWork.PersonnelTaxFileInfoChangeLogRepository.GetByIdAsync(id);

            if (PersonnelTaxFileInfoChangeLog is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PersonnelTaxFileInfoChangeLogDto = Mapper.Map(PersonnelTaxFileInfoChangeLog);

            return OkResult( CustomMessage.DefaultMessage , PersonnelTaxFileInfoChangeLogDto);

        }
    }
}
