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

namespace Sepidar.Api.Controllers.ContractWorkshopItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractWorkshopItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractWorkshopItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractWorkshopItemCommand command)
        {
            command.Validate();

            var ContractWorkshopItems = await _unitOfWork.ContractWorkshopItemRepository.FindAsync(c => c.Id == command.Id);

            if (ContractWorkshopItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractWorkshopItem = Mapper.Map(command);
            await _unitOfWork.ContractWorkshopItemRepository.AddAsync(newContractWorkshopItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractWorkshopItemCommand command)
        {

            command.Validate();

            var ContractWorkshopItem = await _unitOfWork.ContractWorkshopItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractWorkshopItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractWorkshopItem = Mapper.Map(ContractWorkshopItem, command);
            ContractWorkshopItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractWorkshopItem = await _unitOfWork.ContractWorkshopItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractWorkshopItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractWorkshopItem.IsActive = false;
            ContractWorkshopItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractWorkshopItems = await _unitOfWork.ContractWorkshopItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractWorkshopItemsDto = Mapper.Map(ContractWorkshopItems);

            return OkResult(CustomMessage.DefaultMessage, ContractWorkshopItemsDto.ToPagingAndSorting(query), ContractWorkshopItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractWorkshopItem = await _unitOfWork.ContractWorkshopItemRepository.GetByIdAsync(id);

            if (ContractWorkshopItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractWorkshopItemDto = Mapper.Map(ContractWorkshopItem);

            return OkResult( CustomMessage.DefaultMessage , ContractWorkshopItemDto);

        }
    }
}
