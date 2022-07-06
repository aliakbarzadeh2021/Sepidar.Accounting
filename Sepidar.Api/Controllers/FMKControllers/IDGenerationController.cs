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

namespace Sepidar.Api.Controllers.IDGenerationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class IDGenerationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public IDGenerationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddIDGenerationCommand command)
        {
            command.Validate();

            var IDGenerations = await _unitOfWork.IDGenerationRepository.FindAsync(c => c.Id == command.Id);

            if (IDGenerations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newIDGeneration = Mapper.Map(command);
            await _unitOfWork.IDGenerationRepository.AddAsync(newIDGeneration);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditIDGenerationCommand command)
        {

            command.Validate();

            var IDGeneration = await _unitOfWork.IDGenerationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (IDGeneration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            IDGeneration = Mapper.Map(IDGeneration, command);
            IDGeneration.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var IDGeneration = await _unitOfWork.IDGenerationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (IDGeneration == null)
                return NotFound(CustomMessage.NotFoundMessage);

            IDGeneration.IsActive = false;
            IDGeneration.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var IDGenerations = await _unitOfWork.IDGenerationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var IDGenerationsDto = Mapper.Map(IDGenerations);

            return OkResult(CustomMessage.DefaultMessage, IDGenerationsDto.ToPagingAndSorting(query), IDGenerationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var IDGeneration = await _unitOfWork.IDGenerationRepository.GetByIdAsync(id);

            if (IDGeneration is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var IDGenerationDto = Mapper.Map(IDGeneration);

            return OkResult( CustomMessage.DefaultMessage , IDGenerationDto);

        }
    }
}
