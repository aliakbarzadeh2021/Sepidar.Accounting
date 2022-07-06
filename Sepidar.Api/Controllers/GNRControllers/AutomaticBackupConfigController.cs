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

namespace Sepidar.Api.Controllers.AutomaticBackupConfigControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AutomaticBackupConfigController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AutomaticBackupConfigController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAutomaticBackupConfigCommand command)
        {
            command.Validate();

            var AutomaticBackupConfigs = await _unitOfWork.AutomaticBackupConfigRepository.FindAsync(c => c.Id == command.Id);

            if (AutomaticBackupConfigs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAutomaticBackupConfig = Mapper.Map(command);
            await _unitOfWork.AutomaticBackupConfigRepository.AddAsync(newAutomaticBackupConfig);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAutomaticBackupConfigCommand command)
        {

            command.Validate();

            var AutomaticBackupConfig = await _unitOfWork.AutomaticBackupConfigRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AutomaticBackupConfig == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AutomaticBackupConfig = Mapper.Map(AutomaticBackupConfig, command);
            AutomaticBackupConfig.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AutomaticBackupConfig = await _unitOfWork.AutomaticBackupConfigRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AutomaticBackupConfig == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AutomaticBackupConfig.IsActive = false;
            AutomaticBackupConfig.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AutomaticBackupConfigs = await _unitOfWork.AutomaticBackupConfigRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AutomaticBackupConfigsDto = Mapper.Map(AutomaticBackupConfigs);

            return OkResult(CustomMessage.DefaultMessage, AutomaticBackupConfigsDto.ToPagingAndSorting(query), AutomaticBackupConfigsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AutomaticBackupConfig = await _unitOfWork.AutomaticBackupConfigRepository.GetByIdAsync(id);

            if (AutomaticBackupConfig is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AutomaticBackupConfigDto = Mapper.Map(AutomaticBackupConfig);

            return OkResult( CustomMessage.DefaultMessage , AutomaticBackupConfigDto);

        }
    }
}
