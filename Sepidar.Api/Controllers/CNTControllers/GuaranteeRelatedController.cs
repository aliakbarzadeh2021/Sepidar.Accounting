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

namespace Sepidar.Api.Controllers.GuaranteeRelatedControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GuaranteeRelatedController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GuaranteeRelatedController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGuaranteeRelatedCommand command)
        {
            command.Validate();

            var GuaranteeRelateds = await _unitOfWork.GuaranteeRelatedRepository.FindAsync(c => c.Id == command.Id);

            if (GuaranteeRelateds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGuaranteeRelated = Mapper.Map(command);
            await _unitOfWork.GuaranteeRelatedRepository.AddAsync(newGuaranteeRelated);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGuaranteeRelatedCommand command)
        {

            command.Validate();

            var GuaranteeRelated = await _unitOfWork.GuaranteeRelatedRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (GuaranteeRelated == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GuaranteeRelated = Mapper.Map(GuaranteeRelated, command);
            GuaranteeRelated.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var GuaranteeRelated = await _unitOfWork.GuaranteeRelatedRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (GuaranteeRelated == null)
                return NotFound(CustomMessage.NotFoundMessage);

            GuaranteeRelated.IsActive = false;
            GuaranteeRelated.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var GuaranteeRelateds = await _unitOfWork.GuaranteeRelatedRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GuaranteeRelatedsDto = Mapper.Map(GuaranteeRelateds);

            return OkResult(CustomMessage.DefaultMessage, GuaranteeRelatedsDto.ToPagingAndSorting(query), GuaranteeRelatedsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var GuaranteeRelated = await _unitOfWork.GuaranteeRelatedRepository.GetByIdAsync(id);

            if (GuaranteeRelated is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GuaranteeRelatedDto = Mapper.Map(GuaranteeRelated);

            return OkResult( CustomMessage.DefaultMessage , GuaranteeRelatedDto);

        }
    }
}
