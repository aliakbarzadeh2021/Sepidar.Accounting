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

namespace Sepidar.Api.Controllers.ContractCoefficientItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractCoefficientItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractCoefficientItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractCoefficientItemCommand command)
        {
            command.Validate();

            var ContractCoefficientItems = await _unitOfWork.ContractCoefficientItemRepository.FindAsync(c => c.Id == command.Id);

            if (ContractCoefficientItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractCoefficientItem = Mapper.Map(command);
            await _unitOfWork.ContractCoefficientItemRepository.AddAsync(newContractCoefficientItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractCoefficientItemCommand command)
        {

            command.Validate();

            var ContractCoefficientItem = await _unitOfWork.ContractCoefficientItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractCoefficientItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractCoefficientItem = Mapper.Map(ContractCoefficientItem, command);
            ContractCoefficientItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractCoefficientItem = await _unitOfWork.ContractCoefficientItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractCoefficientItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractCoefficientItem.IsActive = false;
            ContractCoefficientItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractCoefficientItems = await _unitOfWork.ContractCoefficientItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractCoefficientItemsDto = Mapper.Map(ContractCoefficientItems);

            return OkResult(CustomMessage.DefaultMessage, ContractCoefficientItemsDto.ToPagingAndSorting(query), ContractCoefficientItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractCoefficientItem = await _unitOfWork.ContractCoefficientItemRepository.GetByIdAsync(id);

            if (ContractCoefficientItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractCoefficientItemDto = Mapper.Map(ContractCoefficientItem);

            return OkResult( CustomMessage.DefaultMessage , ContractCoefficientItemDto);

        }
    }
}
