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

namespace Sepidar.Api.Controllers.EmplacementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EmplacementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmplacementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddEmplacementCommand command)
        {
            command.Validate();

            var Emplacements = await _unitOfWork.EmplacementRepository.FindAsync(c => c.Id == command.Id);

            if (Emplacements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newEmplacement = Mapper.Map(command);
            await _unitOfWork.EmplacementRepository.AddAsync(newEmplacement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditEmplacementCommand command)
        {

            command.Validate();

            var Emplacement = await _unitOfWork.EmplacementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Emplacement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Emplacement = Mapper.Map(Emplacement, command);
            Emplacement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Emplacement = await _unitOfWork.EmplacementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Emplacement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Emplacement.IsActive = false;
            Emplacement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Emplacements = await _unitOfWork.EmplacementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var EmplacementsDto = Mapper.Map(Emplacements);

            return OkResult(CustomMessage.DefaultMessage, EmplacementsDto.ToPagingAndSorting(query), EmplacementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Emplacement = await _unitOfWork.EmplacementRepository.GetByIdAsync(id);

            if (Emplacement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var EmplacementDto = Mapper.Map(Emplacement);

            return OkResult( CustomMessage.DefaultMessage , EmplacementDto);

        }
    }
}
