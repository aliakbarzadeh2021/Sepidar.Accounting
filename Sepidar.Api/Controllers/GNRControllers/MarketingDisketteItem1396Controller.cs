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

namespace Sepidar.Api.Controllers.MarketingDisketteItem1396Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MarketingDisketteItem1396Controller : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarketingDisketteItem1396Controller(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMarketingDisketteItem1396Command command)
        {
            command.Validate();

            var MarketingDisketteItem1396s = await _unitOfWork.MarketingDisketteItem1396Repository.FindAsync(c => c.Id == command.Id);

            if (MarketingDisketteItem1396s.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMarketingDisketteItem1396 = Mapper.Map(command);
            await _unitOfWork.MarketingDisketteItem1396Repository.AddAsync(newMarketingDisketteItem1396);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMarketingDisketteItem1396Command command)
        {

            command.Validate();

            var MarketingDisketteItem1396 = await _unitOfWork.MarketingDisketteItem1396Repository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MarketingDisketteItem1396 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDisketteItem1396 = Mapper.Map(MarketingDisketteItem1396, command);
            MarketingDisketteItem1396.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MarketingDisketteItem1396 = await _unitOfWork.MarketingDisketteItem1396Repository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MarketingDisketteItem1396 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDisketteItem1396.IsActive = false;
            MarketingDisketteItem1396.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MarketingDisketteItem1396s = await _unitOfWork.MarketingDisketteItem1396Repository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MarketingDisketteItem1396sDto = Mapper.Map(MarketingDisketteItem1396s);

            return OkResult(CustomMessage.DefaultMessage, MarketingDisketteItem1396sDto.ToPagingAndSorting(query), MarketingDisketteItem1396sDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MarketingDisketteItem1396 = await _unitOfWork.MarketingDisketteItem1396Repository.GetByIdAsync(id);

            if (MarketingDisketteItem1396 is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MarketingDisketteItem1396Dto = Mapper.Map(MarketingDisketteItem1396);

            return OkResult( CustomMessage.DefaultMessage , MarketingDisketteItem1396Dto);

        }
    }
}
