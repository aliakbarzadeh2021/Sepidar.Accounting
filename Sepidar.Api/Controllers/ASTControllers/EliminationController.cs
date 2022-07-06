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

namespace Sepidar.Api.Controllers.EliminationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EliminationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EliminationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddEliminationCommand command)
        {
            command.Validate();

            var Eliminations = await _unitOfWork.EliminationRepository.FindAsync(c => c.Id == command.Id);

            if (Eliminations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newElimination = Mapper.Map(command);
            await _unitOfWork.EliminationRepository.AddAsync(newElimination);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditEliminationCommand command)
        {

            command.Validate();

            var Elimination = await _unitOfWork.EliminationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Elimination == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Elimination = Mapper.Map(Elimination, command);
            Elimination.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Elimination = await _unitOfWork.EliminationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Elimination == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Elimination.IsActive = false;
            Elimination.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Eliminations = await _unitOfWork.EliminationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var EliminationsDto = Mapper.Map(Eliminations);

            return OkResult(CustomMessage.DefaultMessage, EliminationsDto.ToPagingAndSorting(query), EliminationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Elimination = await _unitOfWork.EliminationRepository.GetByIdAsync(id);

            if (Elimination is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var EliminationDto = Mapper.Map(Elimination);

            return OkResult( CustomMessage.DefaultMessage , EliminationDto);

        }
    }
}
