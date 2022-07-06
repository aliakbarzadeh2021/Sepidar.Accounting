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

namespace Sepidar.Api.Controllers.MonthlyDataPersonnelElementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MonthlyDataPersonnelElementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MonthlyDataPersonnelElementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMonthlyDataPersonnelElementCommand command)
        {
            command.Validate();

            var MonthlyDataPersonnelElements = await _unitOfWork.MonthlyDataPersonnelElementRepository.FindAsync(c => c.Id == command.Id);

            if (MonthlyDataPersonnelElements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMonthlyDataPersonnelElement = Mapper.Map(command);
            await _unitOfWork.MonthlyDataPersonnelElementRepository.AddAsync(newMonthlyDataPersonnelElement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMonthlyDataPersonnelElementCommand command)
        {

            command.Validate();

            var MonthlyDataPersonnelElement = await _unitOfWork.MonthlyDataPersonnelElementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MonthlyDataPersonnelElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MonthlyDataPersonnelElement = Mapper.Map(MonthlyDataPersonnelElement, command);
            MonthlyDataPersonnelElement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MonthlyDataPersonnelElement = await _unitOfWork.MonthlyDataPersonnelElementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MonthlyDataPersonnelElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MonthlyDataPersonnelElement.IsActive = false;
            MonthlyDataPersonnelElement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MonthlyDataPersonnelElements = await _unitOfWork.MonthlyDataPersonnelElementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MonthlyDataPersonnelElementsDto = Mapper.Map(MonthlyDataPersonnelElements);

            return OkResult(CustomMessage.DefaultMessage, MonthlyDataPersonnelElementsDto.ToPagingAndSorting(query), MonthlyDataPersonnelElementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MonthlyDataPersonnelElement = await _unitOfWork.MonthlyDataPersonnelElementRepository.GetByIdAsync(id);

            if (MonthlyDataPersonnelElement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MonthlyDataPersonnelElementDto = Mapper.Map(MonthlyDataPersonnelElement);

            return OkResult( CustomMessage.DefaultMessage , MonthlyDataPersonnelElementDto);

        }
    }
}
