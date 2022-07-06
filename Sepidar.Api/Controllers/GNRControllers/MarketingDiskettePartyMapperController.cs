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

namespace Sepidar.Api.Controllers.MarketingDiskettePartyMapperControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MarketingDiskettePartyMapperController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarketingDiskettePartyMapperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMarketingDiskettePartyMapperCommand command)
        {
            command.Validate();

            var MarketingDiskettePartyMappers = await _unitOfWork.MarketingDiskettePartyMapperRepository.FindAsync(c => c.Id == command.Id);

            if (MarketingDiskettePartyMappers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMarketingDiskettePartyMapper = Mapper.Map(command);
            await _unitOfWork.MarketingDiskettePartyMapperRepository.AddAsync(newMarketingDiskettePartyMapper);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMarketingDiskettePartyMapperCommand command)
        {

            command.Validate();

            var MarketingDiskettePartyMapper = await _unitOfWork.MarketingDiskettePartyMapperRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MarketingDiskettePartyMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDiskettePartyMapper = Mapper.Map(MarketingDiskettePartyMapper, command);
            MarketingDiskettePartyMapper.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MarketingDiskettePartyMapper = await _unitOfWork.MarketingDiskettePartyMapperRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MarketingDiskettePartyMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDiskettePartyMapper.IsActive = false;
            MarketingDiskettePartyMapper.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MarketingDiskettePartyMappers = await _unitOfWork.MarketingDiskettePartyMapperRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MarketingDiskettePartyMappersDto = Mapper.Map(MarketingDiskettePartyMappers);

            return OkResult(CustomMessage.DefaultMessage, MarketingDiskettePartyMappersDto.ToPagingAndSorting(query), MarketingDiskettePartyMappersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MarketingDiskettePartyMapper = await _unitOfWork.MarketingDiskettePartyMapperRepository.GetByIdAsync(id);

            if (MarketingDiskettePartyMapper is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MarketingDiskettePartyMapperDto = Mapper.Map(MarketingDiskettePartyMapper);

            return OkResult( CustomMessage.DefaultMessage , MarketingDiskettePartyMapperDto);

        }
    }
}
