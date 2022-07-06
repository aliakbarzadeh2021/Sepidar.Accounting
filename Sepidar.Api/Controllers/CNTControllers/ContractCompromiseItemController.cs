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

namespace Sepidar.Api.Controllers.ContractCompromiseItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractCompromiseItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractCompromiseItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractCompromiseItemCommand command)
        {
            command.Validate();

            var ContractCompromiseItems = await _unitOfWork.ContractCompromiseItemRepository.FindAsync(c => c.Id == command.Id);

            if (ContractCompromiseItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractCompromiseItem = Mapper.Map(command);
            await _unitOfWork.ContractCompromiseItemRepository.AddAsync(newContractCompromiseItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractCompromiseItemCommand command)
        {

            command.Validate();

            var ContractCompromiseItem = await _unitOfWork.ContractCompromiseItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractCompromiseItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractCompromiseItem = Mapper.Map(ContractCompromiseItem, command);
            ContractCompromiseItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractCompromiseItem = await _unitOfWork.ContractCompromiseItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractCompromiseItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractCompromiseItem.IsActive = false;
            ContractCompromiseItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractCompromiseItems = await _unitOfWork.ContractCompromiseItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractCompromiseItemsDto = Mapper.Map(ContractCompromiseItems);

            return OkResult(CustomMessage.DefaultMessage, ContractCompromiseItemsDto.ToPagingAndSorting(query), ContractCompromiseItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractCompromiseItem = await _unitOfWork.ContractCompromiseItemRepository.GetByIdAsync(id);

            if (ContractCompromiseItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractCompromiseItemDto = Mapper.Map(ContractCompromiseItem);

            return OkResult( CustomMessage.DefaultMessage , ContractCompromiseItemDto);

        }
    }
}
