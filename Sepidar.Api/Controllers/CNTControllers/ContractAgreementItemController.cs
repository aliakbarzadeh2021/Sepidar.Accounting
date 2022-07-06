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

namespace Sepidar.Api.Controllers.ContractAgreementItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractAgreementItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractAgreementItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractAgreementItemCommand command)
        {
            command.Validate();

            var ContractAgreementItems = await _unitOfWork.ContractAgreementItemRepository.FindAsync(c => c.Id == command.Id);

            if (ContractAgreementItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractAgreementItem = Mapper.Map(command);
            await _unitOfWork.ContractAgreementItemRepository.AddAsync(newContractAgreementItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractAgreementItemCommand command)
        {

            command.Validate();

            var ContractAgreementItem = await _unitOfWork.ContractAgreementItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractAgreementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractAgreementItem = Mapper.Map(ContractAgreementItem, command);
            ContractAgreementItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractAgreementItem = await _unitOfWork.ContractAgreementItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractAgreementItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractAgreementItem.IsActive = false;
            ContractAgreementItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractAgreementItems = await _unitOfWork.ContractAgreementItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractAgreementItemsDto = Mapper.Map(ContractAgreementItems);

            return OkResult(CustomMessage.DefaultMessage, ContractAgreementItemsDto.ToPagingAndSorting(query), ContractAgreementItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractAgreementItem = await _unitOfWork.ContractAgreementItemRepository.GetByIdAsync(id);

            if (ContractAgreementItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractAgreementItemDto = Mapper.Map(ContractAgreementItem);

            return OkResult( CustomMessage.DefaultMessage , ContractAgreementItemDto);

        }
    }
}
