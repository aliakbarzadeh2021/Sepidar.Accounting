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

namespace Sepidar.Api.Controllers.ExtraColumnDescriptionControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ExtraColumnDescriptionController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ExtraColumnDescriptionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddExtraColumnDescriptionCommand command)
        {
            command.Validate();

            var ExtraColumnDescriptions = await _unitOfWork.ExtraColumnDescriptionRepository.FindAsync(c => c.Id == command.Id);

            if (ExtraColumnDescriptions.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newExtraColumnDescription = Mapper.Map(command);
            await _unitOfWork.ExtraColumnDescriptionRepository.AddAsync(newExtraColumnDescription);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditExtraColumnDescriptionCommand command)
        {

            command.Validate();

            var ExtraColumnDescription = await _unitOfWork.ExtraColumnDescriptionRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ExtraColumnDescription == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ExtraColumnDescription = Mapper.Map(ExtraColumnDescription, command);
            ExtraColumnDescription.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ExtraColumnDescription = await _unitOfWork.ExtraColumnDescriptionRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ExtraColumnDescription == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ExtraColumnDescription.IsActive = false;
            ExtraColumnDescription.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ExtraColumnDescriptions = await _unitOfWork.ExtraColumnDescriptionRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ExtraColumnDescriptionsDto = Mapper.Map(ExtraColumnDescriptions);

            return OkResult(CustomMessage.DefaultMessage, ExtraColumnDescriptionsDto.ToPagingAndSorting(query), ExtraColumnDescriptionsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ExtraColumnDescription = await _unitOfWork.ExtraColumnDescriptionRepository.GetByIdAsync(id);

            if (ExtraColumnDescription is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ExtraColumnDescriptionDto = Mapper.Map(ExtraColumnDescription);

            return OkResult( CustomMessage.DefaultMessage , ExtraColumnDescriptionDto);

        }
    }
}
