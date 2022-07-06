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

namespace Sepidar.Api.Controllers.ContractPreReceiptItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractPreReceiptItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractPreReceiptItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractPreReceiptItemCommand command)
        {
            command.Validate();

            var ContractPreReceiptItems = await _unitOfWork.ContractPreReceiptItemRepository.FindAsync(c => c.Id == command.Id);

            if (ContractPreReceiptItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractPreReceiptItem = Mapper.Map(command);
            await _unitOfWork.ContractPreReceiptItemRepository.AddAsync(newContractPreReceiptItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractPreReceiptItemCommand command)
        {

            command.Validate();

            var ContractPreReceiptItem = await _unitOfWork.ContractPreReceiptItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractPreReceiptItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractPreReceiptItem = Mapper.Map(ContractPreReceiptItem, command);
            ContractPreReceiptItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractPreReceiptItem = await _unitOfWork.ContractPreReceiptItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractPreReceiptItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractPreReceiptItem.IsActive = false;
            ContractPreReceiptItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractPreReceiptItems = await _unitOfWork.ContractPreReceiptItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractPreReceiptItemsDto = Mapper.Map(ContractPreReceiptItems);

            return OkResult(CustomMessage.DefaultMessage, ContractPreReceiptItemsDto.ToPagingAndSorting(query), ContractPreReceiptItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractPreReceiptItem = await _unitOfWork.ContractPreReceiptItemRepository.GetByIdAsync(id);

            if (ContractPreReceiptItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractPreReceiptItemDto = Mapper.Map(ContractPreReceiptItem);

            return OkResult( CustomMessage.DefaultMessage , ContractPreReceiptItemDto);

        }
    }
}
