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

namespace Sepidar.Api.Controllers.CurrencyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CurrencyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCurrencyCommand command)
        {
            command.Validate();

            var Currencys = await _unitOfWork.CurrencyRepository.FindAsync(c => c.Id == command.Id);

            if (Currencys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCurrency = Mapper.Map(command);
            await _unitOfWork.CurrencyRepository.AddAsync(newCurrency);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCurrencyCommand command)
        {

            command.Validate();

            var Currency = await _unitOfWork.CurrencyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Currency == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Currency = Mapper.Map(Currency, command);
            Currency.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Currency = await _unitOfWork.CurrencyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Currency == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Currency.IsActive = false;
            Currency.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Currencys = await _unitOfWork.CurrencyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CurrencysDto = Mapper.Map(Currencys);

            return OkResult(CustomMessage.DefaultMessage, CurrencysDto.ToPagingAndSorting(query), CurrencysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Currency = await _unitOfWork.CurrencyRepository.GetByIdAsync(id);

            if (Currency is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CurrencyDto = Mapper.Map(Currency);

            return OkResult( CustomMessage.DefaultMessage , CurrencyDto);

        }
    }
}
