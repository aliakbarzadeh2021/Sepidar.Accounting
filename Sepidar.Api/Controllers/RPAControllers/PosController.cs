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

namespace Sepidar.Api.Controllers.PosControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PosController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPosCommand command)
        {
            command.Validate();

            var Poss = await _unitOfWork.PosRepository.FindAsync(c => c.Id == command.Id);

            if (Poss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPos = Mapper.Map(command);
            await _unitOfWork.PosRepository.AddAsync(newPos);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPosCommand command)
        {

            command.Validate();

            var Pos = await _unitOfWork.PosRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Pos == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Pos = Mapper.Map(Pos, command);
            Pos.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Pos = await _unitOfWork.PosRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Pos == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Pos.IsActive = false;
            Pos.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Poss = await _unitOfWork.PosRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PossDto = Mapper.Map(Poss);

            return OkResult(CustomMessage.DefaultMessage, PossDto.ToPagingAndSorting(query), PossDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Pos = await _unitOfWork.PosRepository.GetByIdAsync(id);

            if (Pos is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PosDto = Mapper.Map(Pos);

            return OkResult( CustomMessage.DefaultMessage , PosDto);

        }
    }
}
