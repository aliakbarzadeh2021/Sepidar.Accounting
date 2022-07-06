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

namespace Sepidar.Api.Controllers.SalvageControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SalvageController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalvageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSalvageCommand command)
        {
            command.Validate();

            var Salvages = await _unitOfWork.SalvageRepository.FindAsync(c => c.Id == command.Id);

            if (Salvages.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSalvage = Mapper.Map(command);
            await _unitOfWork.SalvageRepository.AddAsync(newSalvage);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSalvageCommand command)
        {

            command.Validate();

            var Salvage = await _unitOfWork.SalvageRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Salvage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Salvage = Mapper.Map(Salvage, command);
            Salvage.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Salvage = await _unitOfWork.SalvageRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Salvage == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Salvage.IsActive = false;
            Salvage.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Salvages = await _unitOfWork.SalvageRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SalvagesDto = Mapper.Map(Salvages);

            return OkResult(CustomMessage.DefaultMessage, SalvagesDto.ToPagingAndSorting(query), SalvagesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Salvage = await _unitOfWork.SalvageRepository.GetByIdAsync(id);

            if (Salvage is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SalvageDto = Mapper.Map(Salvage);

            return OkResult( CustomMessage.DefaultMessage , SalvageDto);

        }
    }
}
