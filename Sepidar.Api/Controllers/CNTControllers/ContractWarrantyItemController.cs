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

namespace Sepidar.Api.Controllers.ContractWarrantyItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractWarrantyItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractWarrantyItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractWarrantyItemCommand command)
        {
            command.Validate();

            var ContractWarrantyItems = await _unitOfWork.ContractWarrantyItemRepository.FindAsync(c => c.Id == command.Id);

            if (ContractWarrantyItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractWarrantyItem = Mapper.Map(command);
            await _unitOfWork.ContractWarrantyItemRepository.AddAsync(newContractWarrantyItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractWarrantyItemCommand command)
        {

            command.Validate();

            var ContractWarrantyItem = await _unitOfWork.ContractWarrantyItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractWarrantyItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractWarrantyItem = Mapper.Map(ContractWarrantyItem, command);
            ContractWarrantyItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractWarrantyItem = await _unitOfWork.ContractWarrantyItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractWarrantyItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractWarrantyItem.IsActive = false;
            ContractWarrantyItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractWarrantyItems = await _unitOfWork.ContractWarrantyItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractWarrantyItemsDto = Mapper.Map(ContractWarrantyItems);

            return OkResult(CustomMessage.DefaultMessage, ContractWarrantyItemsDto.ToPagingAndSorting(query), ContractWarrantyItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractWarrantyItem = await _unitOfWork.ContractWarrantyItemRepository.GetByIdAsync(id);

            if (ContractWarrantyItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractWarrantyItemDto = Mapper.Map(ContractWarrantyItem);

            return OkResult( CustomMessage.DefaultMessage , ContractWarrantyItemDto);

        }
    }
}
