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

namespace Sepidar.Api.Controllers.StandardDescriptionControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StandardDescriptionController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StandardDescriptionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStandardDescriptionCommand command)
        {
            command.Validate();

            var StandardDescriptions = await _unitOfWork.StandardDescriptionRepository.FindAsync(c => c.Id == command.Id);

            if (StandardDescriptions.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStandardDescription = Mapper.Map(command);
            await _unitOfWork.StandardDescriptionRepository.AddAsync(newStandardDescription);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStandardDescriptionCommand command)
        {

            command.Validate();

            var StandardDescription = await _unitOfWork.StandardDescriptionRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StandardDescription == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StandardDescription = Mapper.Map(StandardDescription, command);
            StandardDescription.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StandardDescription = await _unitOfWork.StandardDescriptionRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StandardDescription == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StandardDescription.IsActive = false;
            StandardDescription.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StandardDescriptions = await _unitOfWork.StandardDescriptionRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StandardDescriptionsDto = Mapper.Map(StandardDescriptions);

            return OkResult(CustomMessage.DefaultMessage, StandardDescriptionsDto.ToPagingAndSorting(query), StandardDescriptionsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StandardDescription = await _unitOfWork.StandardDescriptionRepository.GetByIdAsync(id);

            if (StandardDescription is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StandardDescriptionDto = Mapper.Map(StandardDescription);

            return OkResult( CustomMessage.DefaultMessage , StandardDescriptionDto);

        }
    }
}
