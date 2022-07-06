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

namespace Sepidar.Api.Controllers.Version1Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class Version1Controller : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public Version1Controller(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddVersion1Command command)
        {
            command.Validate();

            var Version1s = await _unitOfWork.Version1Repository.FindAsync(c => c.Id == command.Id);

            if (Version1s.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newVersion1 = Mapper.Map(command);
            await _unitOfWork.Version1Repository.AddAsync(newVersion1);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditVersion1Command command)
        {

            command.Validate();

            var Version1 = await _unitOfWork.Version1Repository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Version1 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Version1 = Mapper.Map(Version1, command);
            Version1.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Version1 = await _unitOfWork.Version1Repository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Version1 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Version1.IsActive = false;
            Version1.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Version1s = await _unitOfWork.Version1Repository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var Version1sDto = Mapper.Map(Version1s);

            return OkResult(CustomMessage.DefaultMessage, Version1sDto.ToPagingAndSorting(query), Version1sDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Version1 = await _unitOfWork.Version1Repository.GetByIdAsync(id);

            if (Version1 is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var Version1Dto = Mapper.Map(Version1);

            return OkResult( CustomMessage.DefaultMessage , Version1Dto);

        }
    }
}
