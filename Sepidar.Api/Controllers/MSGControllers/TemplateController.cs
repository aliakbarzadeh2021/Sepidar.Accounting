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

namespace Sepidar.Api.Controllers.TemplateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TemplateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TemplateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTemplateCommand command)
        {
            command.Validate();

            var Templates = await _unitOfWork.TemplateRepository.FindAsync(c => c.Id == command.Id);

            if (Templates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTemplate = Mapper.Map(command);
            await _unitOfWork.TemplateRepository.AddAsync(newTemplate);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTemplateCommand command)
        {

            command.Validate();

            var Template = await _unitOfWork.TemplateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Template == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Template = Mapper.Map(Template, command);
            Template.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Template = await _unitOfWork.TemplateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Template == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Template.IsActive = false;
            Template.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Templates = await _unitOfWork.TemplateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TemplatesDto = Mapper.Map(Templates);

            return OkResult(CustomMessage.DefaultMessage, TemplatesDto.ToPagingAndSorting(query), TemplatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Template = await _unitOfWork.TemplateRepository.GetByIdAsync(id);

            if (Template is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TemplateDto = Mapper.Map(Template);

            return OkResult( CustomMessage.DefaultMessage , TemplateDto);

        }
    }
}
