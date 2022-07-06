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

namespace Sepidar.Api.Controllers.ReconciliationBankItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReconciliationBankItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReconciliationBankItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReconciliationBankItemCommand command)
        {
            command.Validate();

            var ReconciliationBankItems = await _unitOfWork.ReconciliationBankItemRepository.FindAsync(c => c.Id == command.Id);

            if (ReconciliationBankItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReconciliationBankItem = Mapper.Map(command);
            await _unitOfWork.ReconciliationBankItemRepository.AddAsync(newReconciliationBankItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReconciliationBankItemCommand command)
        {

            command.Validate();

            var ReconciliationBankItem = await _unitOfWork.ReconciliationBankItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReconciliationBankItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReconciliationBankItem = Mapper.Map(ReconciliationBankItem, command);
            ReconciliationBankItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReconciliationBankItem = await _unitOfWork.ReconciliationBankItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReconciliationBankItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReconciliationBankItem.IsActive = false;
            ReconciliationBankItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReconciliationBankItems = await _unitOfWork.ReconciliationBankItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReconciliationBankItemsDto = Mapper.Map(ReconciliationBankItems);

            return OkResult(CustomMessage.DefaultMessage, ReconciliationBankItemsDto.ToPagingAndSorting(query), ReconciliationBankItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReconciliationBankItem = await _unitOfWork.ReconciliationBankItemRepository.GetByIdAsync(id);

            if (ReconciliationBankItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReconciliationBankItemDto = Mapper.Map(ReconciliationBankItem);

            return OkResult( CustomMessage.DefaultMessage , ReconciliationBankItemDto);

        }
    }
}
