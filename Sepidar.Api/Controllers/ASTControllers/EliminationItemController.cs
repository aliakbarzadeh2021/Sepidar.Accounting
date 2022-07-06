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

namespace Sepidar.Api.Controllers.EliminationItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EliminationItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EliminationItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddEliminationItemCommand command)
        {
            command.Validate();

            var EliminationItems = await _unitOfWork.EliminationItemRepository.FindAsync(c => c.Id == command.Id);

            if (EliminationItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newEliminationItem = Mapper.Map(command);
            await _unitOfWork.EliminationItemRepository.AddAsync(newEliminationItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditEliminationItemCommand command)
        {

            command.Validate();

            var EliminationItem = await _unitOfWork.EliminationItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (EliminationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            EliminationItem = Mapper.Map(EliminationItem, command);
            EliminationItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var EliminationItem = await _unitOfWork.EliminationItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (EliminationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            EliminationItem.IsActive = false;
            EliminationItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var EliminationItems = await _unitOfWork.EliminationItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var EliminationItemsDto = Mapper.Map(EliminationItems);

            return OkResult(CustomMessage.DefaultMessage, EliminationItemsDto.ToPagingAndSorting(query), EliminationItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var EliminationItem = await _unitOfWork.EliminationItemRepository.GetByIdAsync(id);

            if (EliminationItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var EliminationItemDto = Mapper.Map(EliminationItem);

            return OkResult( CustomMessage.DefaultMessage , EliminationItemDto);

        }
    }
}
