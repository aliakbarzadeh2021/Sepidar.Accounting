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

namespace Sepidar.Api.Controllers.AdditionFactorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AdditionFactorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdditionFactorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAdditionFactorCommand command)
        {
            command.Validate();

            var AdditionFactors = await _unitOfWork.AdditionFactorRepository.FindAsync(c => c.Id == command.Id);

            if (AdditionFactors.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAdditionFactor = Mapper.Map(command);
            await _unitOfWork.AdditionFactorRepository.AddAsync(newAdditionFactor);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAdditionFactorCommand command)
        {

            command.Validate();

            var AdditionFactor = await _unitOfWork.AdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AdditionFactor = Mapper.Map(AdditionFactor, command);
            AdditionFactor.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AdditionFactor = await _unitOfWork.AdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AdditionFactor.IsActive = false;
            AdditionFactor.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AdditionFactors = await _unitOfWork.AdditionFactorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AdditionFactorsDto = Mapper.Map(AdditionFactors);

            return OkResult(CustomMessage.DefaultMessage, AdditionFactorsDto.ToPagingAndSorting(query), AdditionFactorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AdditionFactor = await _unitOfWork.AdditionFactorRepository.GetByIdAsync(id);

            if (AdditionFactor is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AdditionFactorDto = Mapper.Map(AdditionFactor);

            return OkResult( CustomMessage.DefaultMessage , AdditionFactorDto);

        }
    }
}
