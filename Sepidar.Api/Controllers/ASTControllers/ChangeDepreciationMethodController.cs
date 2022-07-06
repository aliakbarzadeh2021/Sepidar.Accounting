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

namespace Sepidar.Api.Controllers.ChangeDepreciationMethodControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ChangeDepreciationMethodController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChangeDepreciationMethodController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddChangeDepreciationMethodCommand command)
        {
            command.Validate();

            var ChangeDepreciationMethods = await _unitOfWork.ChangeDepreciationMethodRepository.FindAsync(c => c.Id == command.Id);

            if (ChangeDepreciationMethods.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newChangeDepreciationMethod = Mapper.Map(command);
            await _unitOfWork.ChangeDepreciationMethodRepository.AddAsync(newChangeDepreciationMethod);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditChangeDepreciationMethodCommand command)
        {

            command.Validate();

            var ChangeDepreciationMethod = await _unitOfWork.ChangeDepreciationMethodRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ChangeDepreciationMethod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ChangeDepreciationMethod = Mapper.Map(ChangeDepreciationMethod, command);
            ChangeDepreciationMethod.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ChangeDepreciationMethod = await _unitOfWork.ChangeDepreciationMethodRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ChangeDepreciationMethod == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ChangeDepreciationMethod.IsActive = false;
            ChangeDepreciationMethod.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ChangeDepreciationMethods = await _unitOfWork.ChangeDepreciationMethodRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ChangeDepreciationMethodsDto = Mapper.Map(ChangeDepreciationMethods);

            return OkResult(CustomMessage.DefaultMessage, ChangeDepreciationMethodsDto.ToPagingAndSorting(query), ChangeDepreciationMethodsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ChangeDepreciationMethod = await _unitOfWork.ChangeDepreciationMethodRepository.GetByIdAsync(id);

            if (ChangeDepreciationMethod is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ChangeDepreciationMethodDto = Mapper.Map(ChangeDepreciationMethod);

            return OkResult( CustomMessage.DefaultMessage , ChangeDepreciationMethodDto);

        }
    }
}
