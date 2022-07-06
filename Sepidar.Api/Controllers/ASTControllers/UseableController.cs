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

namespace Sepidar.Api.Controllers.UseableControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UseableController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UseableController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUseableCommand command)
        {
            command.Validate();

            var Useables = await _unitOfWork.UseableRepository.FindAsync(c => c.Id == command.Id);

            if (Useables.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUseable = Mapper.Map(command);
            await _unitOfWork.UseableRepository.AddAsync(newUseable);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUseableCommand command)
        {

            command.Validate();

            var Useable = await _unitOfWork.UseableRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Useable == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Useable = Mapper.Map(Useable, command);
            Useable.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Useable = await _unitOfWork.UseableRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Useable == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Useable.IsActive = false;
            Useable.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Useables = await _unitOfWork.UseableRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UseablesDto = Mapper.Map(Useables);

            return OkResult(CustomMessage.DefaultMessage, UseablesDto.ToPagingAndSorting(query), UseablesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Useable = await _unitOfWork.UseableRepository.GetByIdAsync(id);

            if (Useable is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UseableDto = Mapper.Map(Useable);

            return OkResult( CustomMessage.DefaultMessage , UseableDto);

        }
    }
}
