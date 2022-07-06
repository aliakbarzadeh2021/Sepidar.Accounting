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

namespace Sepidar.Api.Controllers.CustomsClearanceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CustomsClearanceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomsClearanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCustomsClearanceCommand command)
        {
            command.Validate();

            var CustomsClearances = await _unitOfWork.CustomsClearanceRepository.FindAsync(c => c.Id == command.Id);

            if (CustomsClearances.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCustomsClearance = Mapper.Map(command);
            await _unitOfWork.CustomsClearanceRepository.AddAsync(newCustomsClearance);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCustomsClearanceCommand command)
        {

            command.Validate();

            var CustomsClearance = await _unitOfWork.CustomsClearanceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CustomsClearance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CustomsClearance = Mapper.Map(CustomsClearance, command);
            CustomsClearance.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CustomsClearance = await _unitOfWork.CustomsClearanceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CustomsClearance == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CustomsClearance.IsActive = false;
            CustomsClearance.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CustomsClearances = await _unitOfWork.CustomsClearanceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CustomsClearancesDto = Mapper.Map(CustomsClearances);

            return OkResult(CustomMessage.DefaultMessage, CustomsClearancesDto.ToPagingAndSorting(query), CustomsClearancesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CustomsClearance = await _unitOfWork.CustomsClearanceRepository.GetByIdAsync(id);

            if (CustomsClearance is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CustomsClearanceDto = Mapper.Map(CustomsClearance);

            return OkResult( CustomMessage.DefaultMessage , CustomsClearanceDto);

        }
    }
}
