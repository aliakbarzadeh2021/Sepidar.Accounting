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

namespace Sepidar.Api.Controllers.BackupControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BackupController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BackupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBackupCommand command)
        {
            command.Validate();

            var Backups = await _unitOfWork.BackupRepository.FindAsync(c => c.Id == command.Id);

            if (Backups.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBackup = Mapper.Map(command);
            await _unitOfWork.BackupRepository.AddAsync(newBackup);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBackupCommand command)
        {

            command.Validate();

            var Backup = await _unitOfWork.BackupRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Backup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Backup = Mapper.Map(Backup, command);
            Backup.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Backup = await _unitOfWork.BackupRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Backup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Backup.IsActive = false;
            Backup.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Backups = await _unitOfWork.BackupRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BackupsDto = Mapper.Map(Backups);

            return OkResult(CustomMessage.DefaultMessage, BackupsDto.ToPagingAndSorting(query), BackupsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Backup = await _unitOfWork.BackupRepository.GetByIdAsync(id);

            if (Backup is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BackupDto = Mapper.Map(Backup);

            return OkResult( CustomMessage.DefaultMessage , BackupDto);

        }
    }
}
