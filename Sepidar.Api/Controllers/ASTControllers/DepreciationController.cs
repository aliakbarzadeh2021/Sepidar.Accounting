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

namespace Sepidar.Api.Controllers.DepreciationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DepreciationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepreciationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDepreciationCommand command)
        {
            command.Validate();

            var Depreciations = await _unitOfWork.DepreciationRepository.FindAsync(c => c.Id == command.Id);

            if (Depreciations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDepreciation = Mapper.Map(command);
            await _unitOfWork.DepreciationRepository.AddAsync(newDepreciation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDepreciationCommand command)
        {

            command.Validate();

            var Depreciation = await _unitOfWork.DepreciationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Depreciation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Depreciation = Mapper.Map(Depreciation, command);
            Depreciation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Depreciation = await _unitOfWork.DepreciationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Depreciation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Depreciation.IsActive = false;
            Depreciation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Depreciations = await _unitOfWork.DepreciationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DepreciationsDto = Mapper.Map(Depreciations);

            return OkResult(CustomMessage.DefaultMessage, DepreciationsDto.ToPagingAndSorting(query), DepreciationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Depreciation = await _unitOfWork.DepreciationRepository.GetByIdAsync(id);

            if (Depreciation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DepreciationDto = Mapper.Map(Depreciation);

            return OkResult( CustomMessage.DefaultMessage , DepreciationDto);

        }
    }
}
