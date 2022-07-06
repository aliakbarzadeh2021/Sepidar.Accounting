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

namespace Sepidar.Api.Controllers.MarketingDisketteCurrencyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MarketingDisketteCurrencyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarketingDisketteCurrencyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMarketingDisketteCurrencyCommand command)
        {
            command.Validate();

            var MarketingDisketteCurrencys = await _unitOfWork.MarketingDisketteCurrencyRepository.FindAsync(c => c.Id == command.Id);

            if (MarketingDisketteCurrencys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMarketingDisketteCurrency = Mapper.Map(command);
            await _unitOfWork.MarketingDisketteCurrencyRepository.AddAsync(newMarketingDisketteCurrency);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMarketingDisketteCurrencyCommand command)
        {

            command.Validate();

            var MarketingDisketteCurrency = await _unitOfWork.MarketingDisketteCurrencyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MarketingDisketteCurrency == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDisketteCurrency = Mapper.Map(MarketingDisketteCurrency, command);
            MarketingDisketteCurrency.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MarketingDisketteCurrency = await _unitOfWork.MarketingDisketteCurrencyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MarketingDisketteCurrency == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDisketteCurrency.IsActive = false;
            MarketingDisketteCurrency.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MarketingDisketteCurrencys = await _unitOfWork.MarketingDisketteCurrencyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MarketingDisketteCurrencysDto = Mapper.Map(MarketingDisketteCurrencys);

            return OkResult(CustomMessage.DefaultMessage, MarketingDisketteCurrencysDto.ToPagingAndSorting(query), MarketingDisketteCurrencysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MarketingDisketteCurrency = await _unitOfWork.MarketingDisketteCurrencyRepository.GetByIdAsync(id);

            if (MarketingDisketteCurrency is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MarketingDisketteCurrencyDto = Mapper.Map(MarketingDisketteCurrency);

            return OkResult( CustomMessage.DefaultMessage , MarketingDisketteCurrencyDto);

        }
    }
}
