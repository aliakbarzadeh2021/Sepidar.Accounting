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

namespace Sepidar.Api.Controllers.MonthlyDataPersonnelControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MonthlyDataPersonnelController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MonthlyDataPersonnelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMonthlyDataPersonnelCommand command)
        {
            command.Validate();

            var MonthlyDataPersonnels = await _unitOfWork.MonthlyDataPersonnelRepository.FindAsync(c => c.Id == command.Id);

            if (MonthlyDataPersonnels.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMonthlyDataPersonnel = Mapper.Map(command);
            await _unitOfWork.MonthlyDataPersonnelRepository.AddAsync(newMonthlyDataPersonnel);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMonthlyDataPersonnelCommand command)
        {

            command.Validate();

            var MonthlyDataPersonnel = await _unitOfWork.MonthlyDataPersonnelRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MonthlyDataPersonnel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MonthlyDataPersonnel = Mapper.Map(MonthlyDataPersonnel, command);
            MonthlyDataPersonnel.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MonthlyDataPersonnel = await _unitOfWork.MonthlyDataPersonnelRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MonthlyDataPersonnel == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MonthlyDataPersonnel.IsActive = false;
            MonthlyDataPersonnel.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MonthlyDataPersonnels = await _unitOfWork.MonthlyDataPersonnelRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MonthlyDataPersonnelsDto = Mapper.Map(MonthlyDataPersonnels);

            return OkResult(CustomMessage.DefaultMessage, MonthlyDataPersonnelsDto.ToPagingAndSorting(query), MonthlyDataPersonnelsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MonthlyDataPersonnel = await _unitOfWork.MonthlyDataPersonnelRepository.GetByIdAsync(id);

            if (MonthlyDataPersonnel is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MonthlyDataPersonnelDto = Mapper.Map(MonthlyDataPersonnel);

            return OkResult( CustomMessage.DefaultMessage , MonthlyDataPersonnelDto);

        }
    }
}
