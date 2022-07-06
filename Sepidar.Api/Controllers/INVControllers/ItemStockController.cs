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

namespace Sepidar.Api.Controllers.ItemStockControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ItemStockController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemStockController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddItemStockCommand command)
        {
            command.Validate();

            var ItemStocks = await _unitOfWork.ItemStockRepository.FindAsync(c => c.Id == command.Id);

            if (ItemStocks.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newItemStock = Mapper.Map(command);
            await _unitOfWork.ItemStockRepository.AddAsync(newItemStock);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditItemStockCommand command)
        {

            command.Validate();

            var ItemStock = await _unitOfWork.ItemStockRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ItemStock == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemStock = Mapper.Map(ItemStock, command);
            ItemStock.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ItemStock = await _unitOfWork.ItemStockRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ItemStock == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemStock.IsActive = false;
            ItemStock.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ItemStocks = await _unitOfWork.ItemStockRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ItemStocksDto = Mapper.Map(ItemStocks);

            return OkResult(CustomMessage.DefaultMessage, ItemStocksDto.ToPagingAndSorting(query), ItemStocksDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ItemStock = await _unitOfWork.ItemStockRepository.GetByIdAsync(id);

            if (ItemStock is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ItemStockDto = Mapper.Map(ItemStock);

            return OkResult( CustomMessage.DefaultMessage , ItemStockDto);

        }
    }
}
