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

namespace Sepidar.Api.Controllers.PerformaControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PerformaController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PerformaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPerformaCommand command)
        {
            command.Validate();

            var Performas = await _unitOfWork.PerformaRepository.FindAsync(c => c.Id == command.Id);

            if (Performas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPerforma = Mapper.Map(command);
            await _unitOfWork.PerformaRepository.AddAsync(newPerforma);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPerformaCommand command)
        {

            command.Validate();

            var Performa = await _unitOfWork.PerformaRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Performa == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Performa = Mapper.Map(Performa, command);
            Performa.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Performa = await _unitOfWork.PerformaRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Performa == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Performa.IsActive = false;
            Performa.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Performas = await _unitOfWork.PerformaRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PerformasDto = Mapper.Map(Performas);

            return OkResult(CustomMessage.DefaultMessage, PerformasDto.ToPagingAndSorting(query), PerformasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Performa = await _unitOfWork.PerformaRepository.GetByIdAsync(id);

            if (Performa is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PerformaDto = Mapper.Map(Performa);

            return OkResult( CustomMessage.DefaultMessage , PerformaDto);

        }
    }
}
