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

namespace Sepidar.Api.Controllers.WorkshopControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WorkshopController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkshopController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWorkshopCommand command)
        {
            command.Validate();

            var Workshops = await _unitOfWork.WorkshopRepository.FindAsync(c => c.Id == command.Id);

            if (Workshops.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWorkshop = Mapper.Map(command);
            await _unitOfWork.WorkshopRepository.AddAsync(newWorkshop);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWorkshopCommand command)
        {

            command.Validate();

            var Workshop = await _unitOfWork.WorkshopRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Workshop == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Workshop = Mapper.Map(Workshop, command);
            Workshop.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Workshop = await _unitOfWork.WorkshopRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Workshop == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Workshop.IsActive = false;
            Workshop.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Workshops = await _unitOfWork.WorkshopRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WorkshopsDto = Mapper.Map(Workshops);

            return OkResult(CustomMessage.DefaultMessage, WorkshopsDto.ToPagingAndSorting(query), WorkshopsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Workshop = await _unitOfWork.WorkshopRepository.GetByIdAsync(id);

            if (Workshop is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WorkshopDto = Mapper.Map(Workshop);

            return OkResult( CustomMessage.DefaultMessage , WorkshopDto);

        }
    }
}
