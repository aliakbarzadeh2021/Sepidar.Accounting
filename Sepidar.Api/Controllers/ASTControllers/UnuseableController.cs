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

namespace Sepidar.Api.Controllers.UnuseableControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UnuseableController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UnuseableController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUnuseableCommand command)
        {
            command.Validate();

            var Unuseables = await _unitOfWork.UnuseableRepository.FindAsync(c => c.Id == command.Id);

            if (Unuseables.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUnuseable = Mapper.Map(command);
            await _unitOfWork.UnuseableRepository.AddAsync(newUnuseable);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUnuseableCommand command)
        {

            command.Validate();

            var Unuseable = await _unitOfWork.UnuseableRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Unuseable == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Unuseable = Mapper.Map(Unuseable, command);
            Unuseable.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Unuseable = await _unitOfWork.UnuseableRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Unuseable == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Unuseable.IsActive = false;
            Unuseable.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Unuseables = await _unitOfWork.UnuseableRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UnuseablesDto = Mapper.Map(Unuseables);

            return OkResult(CustomMessage.DefaultMessage, UnuseablesDto.ToPagingAndSorting(query), UnuseablesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Unuseable = await _unitOfWork.UnuseableRepository.GetByIdAsync(id);

            if (Unuseable is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UnuseableDto = Mapper.Map(Unuseable);

            return OkResult( CustomMessage.DefaultMessage , UnuseableDto);

        }
    }
}
