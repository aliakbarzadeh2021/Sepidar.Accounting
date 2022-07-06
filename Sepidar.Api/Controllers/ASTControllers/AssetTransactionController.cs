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

namespace Sepidar.Api.Controllers.AssetTransactionControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AssetTransactionController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssetTransactionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAssetTransactionCommand command)
        {
            command.Validate();

            var AssetTransactions = await _unitOfWork.AssetTransactionRepository.FindAsync(c => c.Id == command.Id);

            if (AssetTransactions.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAssetTransaction = Mapper.Map(command);
            await _unitOfWork.AssetTransactionRepository.AddAsync(newAssetTransaction);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAssetTransactionCommand command)
        {

            command.Validate();

            var AssetTransaction = await _unitOfWork.AssetTransactionRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AssetTransaction == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AssetTransaction = Mapper.Map(AssetTransaction, command);
            AssetTransaction.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AssetTransaction = await _unitOfWork.AssetTransactionRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AssetTransaction == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AssetTransaction.IsActive = false;
            AssetTransaction.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AssetTransactions = await _unitOfWork.AssetTransactionRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AssetTransactionsDto = Mapper.Map(AssetTransactions);

            return OkResult(CustomMessage.DefaultMessage, AssetTransactionsDto.ToPagingAndSorting(query), AssetTransactionsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AssetTransaction = await _unitOfWork.AssetTransactionRepository.GetByIdAsync(id);

            if (AssetTransaction is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AssetTransactionDto = Mapper.Map(AssetTransaction);

            return OkResult( CustomMessage.DefaultMessage , AssetTransactionDto);

        }
    }
}
