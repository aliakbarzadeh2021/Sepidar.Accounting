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

namespace Sepidar.Api.Controllers.MarketingDiskette1396Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MarketingDiskette1396Controller : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarketingDiskette1396Controller(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMarketingDiskette1396Command command)
        {
            command.Validate();

            var MarketingDiskette1396s = await _unitOfWork.MarketingDiskette1396Repository.FindAsync(c => c.Id == command.Id);

            if (MarketingDiskette1396s.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMarketingDiskette1396 = Mapper.Map(command);
            await _unitOfWork.MarketingDiskette1396Repository.AddAsync(newMarketingDiskette1396);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMarketingDiskette1396Command command)
        {

            command.Validate();

            var MarketingDiskette1396 = await _unitOfWork.MarketingDiskette1396Repository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MarketingDiskette1396 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDiskette1396 = Mapper.Map(MarketingDiskette1396, command);
            MarketingDiskette1396.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MarketingDiskette1396 = await _unitOfWork.MarketingDiskette1396Repository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MarketingDiskette1396 == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDiskette1396.IsActive = false;
            MarketingDiskette1396.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MarketingDiskette1396s = await _unitOfWork.MarketingDiskette1396Repository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MarketingDiskette1396sDto = Mapper.Map(MarketingDiskette1396s);

            return OkResult(CustomMessage.DefaultMessage, MarketingDiskette1396sDto.ToPagingAndSorting(query), MarketingDiskette1396sDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MarketingDiskette1396 = await _unitOfWork.MarketingDiskette1396Repository.GetByIdAsync(id);

            if (MarketingDiskette1396 is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MarketingDiskette1396Dto = Mapper.Map(MarketingDiskette1396);

            return OkResult( CustomMessage.DefaultMessage , MarketingDiskette1396Dto);

        }
    }
}
