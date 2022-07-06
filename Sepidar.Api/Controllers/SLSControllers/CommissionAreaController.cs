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

namespace Sepidar.Api.Controllers.CommissionAreaControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionAreaController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommissionAreaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommissionAreaCommand command)
        {
            command.Validate();

            var CommissionAreas = await _unitOfWork.CommissionAreaRepository.FindAsync(c => c.Id == command.Id);

            if (CommissionAreas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommissionArea = Mapper.Map(command);
            await _unitOfWork.CommissionAreaRepository.AddAsync(newCommissionArea);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommissionAreaCommand command)
        {

            command.Validate();

            var CommissionArea = await _unitOfWork.CommissionAreaRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommissionArea == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionArea = Mapper.Map(CommissionArea, command);
            CommissionArea.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommissionArea = await _unitOfWork.CommissionAreaRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommissionArea == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionArea.IsActive = false;
            CommissionArea.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommissionAreas = await _unitOfWork.CommissionAreaRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommissionAreasDto = Mapper.Map(CommissionAreas);

            return OkResult(CustomMessage.DefaultMessage, CommissionAreasDto.ToPagingAndSorting(query), CommissionAreasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommissionArea = await _unitOfWork.CommissionAreaRepository.GetByIdAsync(id);

            if (CommissionArea is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommissionAreaDto = Mapper.Map(CommissionArea);

            return OkResult( CustomMessage.DefaultMessage , CommissionAreaDto);

        }
    }
}
