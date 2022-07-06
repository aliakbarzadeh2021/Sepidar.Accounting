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

namespace Sepidar.Api.Controllers.TemplateSchedulingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TemplateSchedulingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TemplateSchedulingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTemplateSchedulingCommand command)
        {
            command.Validate();

            var TemplateSchedulings = await _unitOfWork.TemplateSchedulingRepository.FindAsync(c => c.Id == command.Id);

            if (TemplateSchedulings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTemplateScheduling = Mapper.Map(command);
            await _unitOfWork.TemplateSchedulingRepository.AddAsync(newTemplateScheduling);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTemplateSchedulingCommand command)
        {

            command.Validate();

            var TemplateScheduling = await _unitOfWork.TemplateSchedulingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TemplateScheduling == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TemplateScheduling = Mapper.Map(TemplateScheduling, command);
            TemplateScheduling.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TemplateScheduling = await _unitOfWork.TemplateSchedulingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TemplateScheduling == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TemplateScheduling.IsActive = false;
            TemplateScheduling.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TemplateSchedulings = await _unitOfWork.TemplateSchedulingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TemplateSchedulingsDto = Mapper.Map(TemplateSchedulings);

            return OkResult(CustomMessage.DefaultMessage, TemplateSchedulingsDto.ToPagingAndSorting(query), TemplateSchedulingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TemplateScheduling = await _unitOfWork.TemplateSchedulingRepository.GetByIdAsync(id);

            if (TemplateScheduling is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TemplateSchedulingDto = Mapper.Map(TemplateScheduling);

            return OkResult( CustomMessage.DefaultMessage , TemplateSchedulingDto);

        }
    }
}
