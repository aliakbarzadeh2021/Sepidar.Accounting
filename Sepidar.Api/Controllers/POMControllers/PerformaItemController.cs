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

namespace Sepidar.Api.Controllers.PerformaItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PerformaItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PerformaItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPerformaItemCommand command)
        {
            command.Validate();

            var PerformaItems = await _unitOfWork.PerformaItemRepository.FindAsync(c => c.Id == command.Id);

            if (PerformaItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPerformaItem = Mapper.Map(command);
            await _unitOfWork.PerformaItemRepository.AddAsync(newPerformaItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPerformaItemCommand command)
        {

            command.Validate();

            var PerformaItem = await _unitOfWork.PerformaItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PerformaItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PerformaItem = Mapper.Map(PerformaItem, command);
            PerformaItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PerformaItem = await _unitOfWork.PerformaItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PerformaItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PerformaItem.IsActive = false;
            PerformaItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PerformaItems = await _unitOfWork.PerformaItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PerformaItemsDto = Mapper.Map(PerformaItems);

            return OkResult(CustomMessage.DefaultMessage, PerformaItemsDto.ToPagingAndSorting(query), PerformaItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PerformaItem = await _unitOfWork.PerformaItemRepository.GetByIdAsync(id);

            if (PerformaItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PerformaItemDto = Mapper.Map(PerformaItem);

            return OkResult( CustomMessage.DefaultMessage , PerformaItemDto);

        }
    }
}
