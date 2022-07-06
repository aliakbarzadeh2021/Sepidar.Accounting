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

namespace Sepidar.Api.Controllers.LogoControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LogoController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public LogoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddLogoCommand command)
        {
            command.Validate();

            var Logos = await _unitOfWork.LogoRepository.FindAsync(c => c.Id == command.Id);

            if (Logos.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newLogo = Mapper.Map(command);
            await _unitOfWork.LogoRepository.AddAsync(newLogo);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditLogoCommand command)
        {

            command.Validate();

            var Logo = await _unitOfWork.LogoRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Logo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Logo = Mapper.Map(Logo, command);
            Logo.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Logo = await _unitOfWork.LogoRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Logo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Logo.IsActive = false;
            Logo.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Logos = await _unitOfWork.LogoRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var LogosDto = Mapper.Map(Logos);

            return OkResult(CustomMessage.DefaultMessage, LogosDto.ToPagingAndSorting(query), LogosDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Logo = await _unitOfWork.LogoRepository.GetByIdAsync(id);

            if (Logo is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var LogoDto = Mapper.Map(Logo);

            return OkResult( CustomMessage.DefaultMessage , LogoDto);

        }
    }
}
