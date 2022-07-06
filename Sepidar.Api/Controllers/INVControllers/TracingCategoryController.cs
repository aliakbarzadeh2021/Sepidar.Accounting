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

namespace Sepidar.Api.Controllers.TracingCategoryControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TracingCategoryController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TracingCategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTracingCategoryCommand command)
        {
            command.Validate();

            var TracingCategorys = await _unitOfWork.TracingCategoryRepository.FindAsync(c => c.Id == command.Id);

            if (TracingCategorys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTracingCategory = Mapper.Map(command);
            await _unitOfWork.TracingCategoryRepository.AddAsync(newTracingCategory);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTracingCategoryCommand command)
        {

            command.Validate();

            var TracingCategory = await _unitOfWork.TracingCategoryRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TracingCategory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TracingCategory = Mapper.Map(TracingCategory, command);
            TracingCategory.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TracingCategory = await _unitOfWork.TracingCategoryRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TracingCategory == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TracingCategory.IsActive = false;
            TracingCategory.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TracingCategorys = await _unitOfWork.TracingCategoryRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TracingCategorysDto = Mapper.Map(TracingCategorys);

            return OkResult(CustomMessage.DefaultMessage, TracingCategorysDto.ToPagingAndSorting(query), TracingCategorysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TracingCategory = await _unitOfWork.TracingCategoryRepository.GetByIdAsync(id);

            if (TracingCategory is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TracingCategoryDto = Mapper.Map(TracingCategory);

            return OkResult( CustomMessage.DefaultMessage , TracingCategoryDto);

        }
    }
}
