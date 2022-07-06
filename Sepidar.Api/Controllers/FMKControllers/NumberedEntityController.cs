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

namespace Sepidar.Api.Controllers.NumberedEntityControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class NumberedEntityController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public NumberedEntityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddNumberedEntityCommand command)
        {
            command.Validate();

            var NumberedEntitys = await _unitOfWork.NumberedEntityRepository.FindAsync(c => c.Id == command.Id);

            if (NumberedEntitys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newNumberedEntity = Mapper.Map(command);
            await _unitOfWork.NumberedEntityRepository.AddAsync(newNumberedEntity);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditNumberedEntityCommand command)
        {

            command.Validate();

            var NumberedEntity = await _unitOfWork.NumberedEntityRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (NumberedEntity == null)
                return NotFound(CustomMessage.NotFoundMessage);

            NumberedEntity = Mapper.Map(NumberedEntity, command);
            NumberedEntity.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var NumberedEntity = await _unitOfWork.NumberedEntityRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (NumberedEntity == null)
                return NotFound(CustomMessage.NotFoundMessage);

            NumberedEntity.IsActive = false;
            NumberedEntity.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var NumberedEntitys = await _unitOfWork.NumberedEntityRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var NumberedEntitysDto = Mapper.Map(NumberedEntitys);

            return OkResult(CustomMessage.DefaultMessage, NumberedEntitysDto.ToPagingAndSorting(query), NumberedEntitysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var NumberedEntity = await _unitOfWork.NumberedEntityRepository.GetByIdAsync(id);

            if (NumberedEntity is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var NumberedEntityDto = Mapper.Map(NumberedEntity);

            return OkResult( CustomMessage.DefaultMessage , NumberedEntityDto);

        }
    }
}
