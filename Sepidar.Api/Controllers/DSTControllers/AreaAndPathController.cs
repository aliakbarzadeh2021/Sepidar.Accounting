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

namespace Sepidar.Api.Controllers.AreaAndPathControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AreaAndPathController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AreaAndPathController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAreaAndPathCommand command)
        {
            command.Validate();

            var AreaAndPaths = await _unitOfWork.AreaAndPathRepository.FindAsync(c => c.Id == command.Id);

            if (AreaAndPaths.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAreaAndPath = Mapper.Map(command);
            await _unitOfWork.AreaAndPathRepository.AddAsync(newAreaAndPath);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAreaAndPathCommand command)
        {

            command.Validate();

            var AreaAndPath = await _unitOfWork.AreaAndPathRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AreaAndPath == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AreaAndPath = Mapper.Map(AreaAndPath, command);
            AreaAndPath.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AreaAndPath = await _unitOfWork.AreaAndPathRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AreaAndPath == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AreaAndPath.IsActive = false;
            AreaAndPath.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AreaAndPaths = await _unitOfWork.AreaAndPathRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AreaAndPathsDto = Mapper.Map(AreaAndPaths);

            return OkResult(CustomMessage.DefaultMessage, AreaAndPathsDto.ToPagingAndSorting(query), AreaAndPathsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AreaAndPath = await _unitOfWork.AreaAndPathRepository.GetByIdAsync(id);

            if (AreaAndPath is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AreaAndPathDto = Mapper.Map(AreaAndPath);

            return OkResult( CustomMessage.DefaultMessage , AreaAndPathDto);

        }
    }
}
