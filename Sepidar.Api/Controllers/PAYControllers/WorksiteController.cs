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

namespace Sepidar.Api.Controllers.WorksiteControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WorksiteController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorksiteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWorksiteCommand command)
        {
            command.Validate();

            var Worksites = await _unitOfWork.WorksiteRepository.FindAsync(c => c.Id == command.Id);

            if (Worksites.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWorksite = Mapper.Map(command);
            await _unitOfWork.WorksiteRepository.AddAsync(newWorksite);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWorksiteCommand command)
        {

            command.Validate();

            var Worksite = await _unitOfWork.WorksiteRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Worksite == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Worksite = Mapper.Map(Worksite, command);
            Worksite.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Worksite = await _unitOfWork.WorksiteRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Worksite == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Worksite.IsActive = false;
            Worksite.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Worksites = await _unitOfWork.WorksiteRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WorksitesDto = Mapper.Map(Worksites);

            return OkResult(CustomMessage.DefaultMessage, WorksitesDto.ToPagingAndSorting(query), WorksitesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Worksite = await _unitOfWork.WorksiteRepository.GetByIdAsync(id);

            if (Worksite is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WorksiteDto = Mapper.Map(Worksite);

            return OkResult( CustomMessage.DefaultMessage , WorksiteDto);

        }
    }
}
