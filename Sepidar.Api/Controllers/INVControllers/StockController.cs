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

namespace Sepidar.Api.Controllers.StockControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StockController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStockCommand command)
        {
            command.Validate();

            var Stocks = await _unitOfWork.StockRepository.FindAsync(c => c.Id == command.Id);

            if (Stocks.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStock = Mapper.Map(command);
            await _unitOfWork.StockRepository.AddAsync(newStock);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStockCommand command)
        {

            command.Validate();

            var Stock = await _unitOfWork.StockRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Stock == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Stock = Mapper.Map(Stock, command);
            Stock.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Stock = await _unitOfWork.StockRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Stock == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Stock.IsActive = false;
            Stock.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Stocks = await _unitOfWork.StockRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StocksDto = Mapper.Map(Stocks);

            return OkResult(CustomMessage.DefaultMessage, StocksDto.ToPagingAndSorting(query), StocksDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Stock = await _unitOfWork.StockRepository.GetByIdAsync(id);

            if (Stock is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StockDto = Mapper.Map(Stock);

            return OkResult( CustomMessage.DefaultMessage , StockDto);

        }
    }
}
