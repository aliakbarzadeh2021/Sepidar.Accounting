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

namespace Sepidar.Api.Controllers.AdditionFactorItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AdditionFactorItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdditionFactorItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAdditionFactorItemCommand command)
        {
            command.Validate();

            var AdditionFactorItems = await _unitOfWork.AdditionFactorItemRepository.FindAsync(c => c.Id == command.Id);

            if (AdditionFactorItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAdditionFactorItem = Mapper.Map(command);
            await _unitOfWork.AdditionFactorItemRepository.AddAsync(newAdditionFactorItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAdditionFactorItemCommand command)
        {

            command.Validate();

            var AdditionFactorItem = await _unitOfWork.AdditionFactorItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AdditionFactorItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AdditionFactorItem = Mapper.Map(AdditionFactorItem, command);
            AdditionFactorItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AdditionFactorItem = await _unitOfWork.AdditionFactorItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AdditionFactorItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AdditionFactorItem.IsActive = false;
            AdditionFactorItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AdditionFactorItems = await _unitOfWork.AdditionFactorItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AdditionFactorItemsDto = Mapper.Map(AdditionFactorItems);

            return OkResult(CustomMessage.DefaultMessage, AdditionFactorItemsDto.ToPagingAndSorting(query), AdditionFactorItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AdditionFactorItem = await _unitOfWork.AdditionFactorItemRepository.GetByIdAsync(id);

            if (AdditionFactorItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AdditionFactorItemDto = Mapper.Map(AdditionFactorItem);

            return OkResult( CustomMessage.DefaultMessage , AdditionFactorItemDto);

        }
    }
}
