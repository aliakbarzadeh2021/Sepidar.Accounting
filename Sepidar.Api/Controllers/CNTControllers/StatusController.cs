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

namespace Sepidar.Api.Controllers.StatusControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StatusController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStatusCommand command)
        {
            command.Validate();

            var Statuss = await _unitOfWork.StatusRepository.FindAsync(c => c.Id == command.Id);

            if (Statuss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStatus = Mapper.Map(command);
            await _unitOfWork.StatusRepository.AddAsync(newStatus);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStatusCommand command)
        {

            command.Validate();

            var Status = await _unitOfWork.StatusRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Status == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Status = Mapper.Map(Status, command);
            Status.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Status = await _unitOfWork.StatusRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Status == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Status.IsActive = false;
            Status.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Statuss = await _unitOfWork.StatusRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StatussDto = Mapper.Map(Statuss);

            return OkResult(CustomMessage.DefaultMessage, StatussDto.ToPagingAndSorting(query), StatussDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Status = await _unitOfWork.StatusRepository.GetByIdAsync(id);

            if (Status is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StatusDto = Mapper.Map(Status);

            return OkResult( CustomMessage.DefaultMessage , StatusDto);

        }
    }
}
