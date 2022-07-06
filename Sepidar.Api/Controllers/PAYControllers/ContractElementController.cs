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

namespace Sepidar.Api.Controllers.ContractElementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractElementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractElementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractElementCommand command)
        {
            command.Validate();

            var ContractElements = await _unitOfWork.ContractElementRepository.FindAsync(c => c.Id == command.Id);

            if (ContractElements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractElement = Mapper.Map(command);
            await _unitOfWork.ContractElementRepository.AddAsync(newContractElement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractElementCommand command)
        {

            command.Validate();

            var ContractElement = await _unitOfWork.ContractElementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractElement = Mapper.Map(ContractElement, command);
            ContractElement.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractElement = await _unitOfWork.ContractElementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractElement == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractElement.IsActive = false;
            ContractElement.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractElements = await _unitOfWork.ContractElementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractElementsDto = Mapper.Map(ContractElements);

            return OkResult(CustomMessage.DefaultMessage, ContractElementsDto.ToPagingAndSorting(query), ContractElementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractElement = await _unitOfWork.ContractElementRepository.GetByIdAsync(id);

            if (ContractElement is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractElementDto = Mapper.Map(ContractElement);

            return OkResult( CustomMessage.DefaultMessage , ContractElementDto);

        }
    }
}
