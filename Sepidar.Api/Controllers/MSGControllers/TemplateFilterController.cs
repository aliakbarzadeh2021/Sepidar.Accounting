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

namespace Sepidar.Api.Controllers.TemplateFilterControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TemplateFilterController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TemplateFilterController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTemplateFilterCommand command)
        {
            command.Validate();

            var TemplateFilters = await _unitOfWork.TemplateFilterRepository.FindAsync(c => c.Id == command.Id);

            if (TemplateFilters.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTemplateFilter = Mapper.Map(command);
            await _unitOfWork.TemplateFilterRepository.AddAsync(newTemplateFilter);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTemplateFilterCommand command)
        {

            command.Validate();

            var TemplateFilter = await _unitOfWork.TemplateFilterRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TemplateFilter == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TemplateFilter = Mapper.Map(TemplateFilter, command);
            TemplateFilter.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TemplateFilter = await _unitOfWork.TemplateFilterRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TemplateFilter == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TemplateFilter.IsActive = false;
            TemplateFilter.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TemplateFilters = await _unitOfWork.TemplateFilterRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TemplateFiltersDto = Mapper.Map(TemplateFilters);

            return OkResult(CustomMessage.DefaultMessage, TemplateFiltersDto.ToPagingAndSorting(query), TemplateFiltersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TemplateFilter = await _unitOfWork.TemplateFilterRepository.GetByIdAsync(id);

            if (TemplateFilter is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TemplateFilterDto = Mapper.Map(TemplateFilter);

            return OkResult( CustomMessage.DefaultMessage , TemplateFilterDto);

        }
    }
}
