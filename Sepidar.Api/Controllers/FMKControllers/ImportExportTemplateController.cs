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

namespace Sepidar.Api.Controllers.ImportExportTemplateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ImportExportTemplateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ImportExportTemplateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddImportExportTemplateCommand command)
        {
            command.Validate();

            var ImportExportTemplates = await _unitOfWork.ImportExportTemplateRepository.FindAsync(c => c.Id == command.Id);

            if (ImportExportTemplates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newImportExportTemplate = Mapper.Map(command);
            await _unitOfWork.ImportExportTemplateRepository.AddAsync(newImportExportTemplate);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditImportExportTemplateCommand command)
        {

            command.Validate();

            var ImportExportTemplate = await _unitOfWork.ImportExportTemplateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ImportExportTemplate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ImportExportTemplate = Mapper.Map(ImportExportTemplate, command);
            ImportExportTemplate.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ImportExportTemplate = await _unitOfWork.ImportExportTemplateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ImportExportTemplate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ImportExportTemplate.IsActive = false;
            ImportExportTemplate.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ImportExportTemplates = await _unitOfWork.ImportExportTemplateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ImportExportTemplatesDto = Mapper.Map(ImportExportTemplates);

            return OkResult(CustomMessage.DefaultMessage, ImportExportTemplatesDto.ToPagingAndSorting(query), ImportExportTemplatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ImportExportTemplate = await _unitOfWork.ImportExportTemplateRepository.GetByIdAsync(id);

            if (ImportExportTemplate is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ImportExportTemplateDto = Mapper.Map(ImportExportTemplate);

            return OkResult( CustomMessage.DefaultMessage , ImportExportTemplateDto);

        }
    }
}
