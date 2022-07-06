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

namespace Sepidar.Api.Controllers.ContractEmployerMaterialsItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractEmployerMaterialsItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractEmployerMaterialsItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractEmployerMaterialsItemCommand command)
        {
            command.Validate();

            var ContractEmployerMaterialsItems = await _unitOfWork.ContractEmployerMaterialsItemRepository.FindAsync(c => c.Id == command.Id);

            if (ContractEmployerMaterialsItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractEmployerMaterialsItem = Mapper.Map(command);
            await _unitOfWork.ContractEmployerMaterialsItemRepository.AddAsync(newContractEmployerMaterialsItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractEmployerMaterialsItemCommand command)
        {

            command.Validate();

            var ContractEmployerMaterialsItem = await _unitOfWork.ContractEmployerMaterialsItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractEmployerMaterialsItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractEmployerMaterialsItem = Mapper.Map(ContractEmployerMaterialsItem, command);
            ContractEmployerMaterialsItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractEmployerMaterialsItem = await _unitOfWork.ContractEmployerMaterialsItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractEmployerMaterialsItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractEmployerMaterialsItem.IsActive = false;
            ContractEmployerMaterialsItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractEmployerMaterialsItems = await _unitOfWork.ContractEmployerMaterialsItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractEmployerMaterialsItemsDto = Mapper.Map(ContractEmployerMaterialsItems);

            return OkResult(CustomMessage.DefaultMessage, ContractEmployerMaterialsItemsDto.ToPagingAndSorting(query), ContractEmployerMaterialsItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractEmployerMaterialsItem = await _unitOfWork.ContractEmployerMaterialsItemRepository.GetByIdAsync(id);

            if (ContractEmployerMaterialsItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractEmployerMaterialsItemDto = Mapper.Map(ContractEmployerMaterialsItem);

            return OkResult( CustomMessage.DefaultMessage , ContractEmployerMaterialsItemDto);

        }
    }
}
