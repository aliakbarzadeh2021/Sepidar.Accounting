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

namespace Sepidar.Api.Controllers.HotDistributionPathControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HotDistributionPathController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public HotDistributionPathController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddHotDistributionPathCommand command)
        {
            command.Validate();

            var HotDistributionPaths = await _unitOfWork.HotDistributionPathRepository.FindAsync(c => c.Id == command.Id);

            if (HotDistributionPaths.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newHotDistributionPath = Mapper.Map(command);
            await _unitOfWork.HotDistributionPathRepository.AddAsync(newHotDistributionPath);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditHotDistributionPathCommand command)
        {

            command.Validate();

            var HotDistributionPath = await _unitOfWork.HotDistributionPathRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (HotDistributionPath == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionPath = Mapper.Map(HotDistributionPath, command);
            HotDistributionPath.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var HotDistributionPath = await _unitOfWork.HotDistributionPathRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (HotDistributionPath == null)
                return NotFound(CustomMessage.NotFoundMessage);

            HotDistributionPath.IsActive = false;
            HotDistributionPath.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var HotDistributionPaths = await _unitOfWork.HotDistributionPathRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var HotDistributionPathsDto = Mapper.Map(HotDistributionPaths);

            return OkResult(CustomMessage.DefaultMessage, HotDistributionPathsDto.ToPagingAndSorting(query), HotDistributionPathsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var HotDistributionPath = await _unitOfWork.HotDistributionPathRepository.GetByIdAsync(id);

            if (HotDistributionPath is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var HotDistributionPathDto = Mapper.Map(HotDistributionPath);

            return OkResult( CustomMessage.DefaultMessage , HotDistributionPathDto);

        }
    }
}
