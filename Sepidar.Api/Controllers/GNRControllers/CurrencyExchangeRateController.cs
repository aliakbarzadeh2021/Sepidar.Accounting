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

namespace Sepidar.Api.Controllers.CurrencyExchangeRateControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyExchangeRateController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CurrencyExchangeRateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCurrencyExchangeRateCommand command)
        {
            command.Validate();

            var CurrencyExchangeRates = await _unitOfWork.CurrencyExchangeRateRepository.FindAsync(c => c.Id == command.Id);

            if (CurrencyExchangeRates.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCurrencyExchangeRate = Mapper.Map(command);
            await _unitOfWork.CurrencyExchangeRateRepository.AddAsync(newCurrencyExchangeRate);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCurrencyExchangeRateCommand command)
        {

            command.Validate();

            var CurrencyExchangeRate = await _unitOfWork.CurrencyExchangeRateRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CurrencyExchangeRate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CurrencyExchangeRate = Mapper.Map(CurrencyExchangeRate, command);
            CurrencyExchangeRate.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CurrencyExchangeRate = await _unitOfWork.CurrencyExchangeRateRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CurrencyExchangeRate == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CurrencyExchangeRate.IsActive = false;
            CurrencyExchangeRate.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CurrencyExchangeRates = await _unitOfWork.CurrencyExchangeRateRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CurrencyExchangeRatesDto = Mapper.Map(CurrencyExchangeRates);

            return OkResult(CustomMessage.DefaultMessage, CurrencyExchangeRatesDto.ToPagingAndSorting(query), CurrencyExchangeRatesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CurrencyExchangeRate = await _unitOfWork.CurrencyExchangeRateRepository.GetByIdAsync(id);

            if (CurrencyExchangeRate is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CurrencyExchangeRateDto = Mapper.Map(CurrencyExchangeRate);

            return OkResult( CustomMessage.DefaultMessage , CurrencyExchangeRateDto);

        }
    }
}
