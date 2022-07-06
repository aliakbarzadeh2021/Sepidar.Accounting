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

namespace Sepidar.Api.Controllers.MarketingDisketteControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MarketingDisketteController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarketingDisketteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMarketingDisketteCommand command)
        {
            command.Validate();

            var MarketingDiskettes = await _unitOfWork.MarketingDisketteRepository.FindAsync(c => c.Id == command.Id);

            if (MarketingDiskettes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMarketingDiskette = Mapper.Map(command);
            await _unitOfWork.MarketingDisketteRepository.AddAsync(newMarketingDiskette);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMarketingDisketteCommand command)
        {

            command.Validate();

            var MarketingDiskette = await _unitOfWork.MarketingDisketteRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MarketingDiskette == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDiskette = Mapper.Map(MarketingDiskette, command);
            MarketingDiskette.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MarketingDiskette = await _unitOfWork.MarketingDisketteRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MarketingDiskette == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDiskette.IsActive = false;
            MarketingDiskette.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MarketingDiskettes = await _unitOfWork.MarketingDisketteRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MarketingDiskettesDto = Mapper.Map(MarketingDiskettes);

            return OkResult(CustomMessage.DefaultMessage, MarketingDiskettesDto.ToPagingAndSorting(query), MarketingDiskettesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MarketingDiskette = await _unitOfWork.MarketingDisketteRepository.GetByIdAsync(id);

            if (MarketingDiskette is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MarketingDisketteDto = Mapper.Map(MarketingDiskette);

            return OkResult( CustomMessage.DefaultMessage , MarketingDisketteDto);

        }
    }
}
