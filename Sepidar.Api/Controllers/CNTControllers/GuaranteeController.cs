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

namespace Sepidar.Api.Controllers.GuaranteeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GuaranteeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public GuaranteeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddGuaranteeCommand command)
        {
            command.Validate();

            var Guarantees = await _unitOfWork.GuaranteeRepository.FindAsync(c => c.Id == command.Id);

            if (Guarantees.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newGuarantee = Mapper.Map(command);
            await _unitOfWork.GuaranteeRepository.AddAsync(newGuarantee);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditGuaranteeCommand command)
        {

            command.Validate();

            var Guarantee = await _unitOfWork.GuaranteeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Guarantee == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Guarantee = Mapper.Map(Guarantee, command);
            Guarantee.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Guarantee = await _unitOfWork.GuaranteeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Guarantee == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Guarantee.IsActive = false;
            Guarantee.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Guarantees = await _unitOfWork.GuaranteeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var GuaranteesDto = Mapper.Map(Guarantees);

            return OkResult(CustomMessage.DefaultMessage, GuaranteesDto.ToPagingAndSorting(query), GuaranteesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Guarantee = await _unitOfWork.GuaranteeRepository.GetByIdAsync(id);

            if (Guarantee is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var GuaranteeDto = Mapper.Map(Guarantee);

            return OkResult( CustomMessage.DefaultMessage , GuaranteeDto);

        }
    }
}
