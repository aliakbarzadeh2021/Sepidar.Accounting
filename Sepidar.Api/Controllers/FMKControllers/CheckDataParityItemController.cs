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

namespace Sepidar.Api.Controllers.CheckDataParityItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CheckDataParityItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CheckDataParityItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCheckDataParityItemCommand command)
        {
            command.Validate();

            var CheckDataParityItems = await _unitOfWork.CheckDataParityItemRepository.FindAsync(c => c.Id == command.Id);

            if (CheckDataParityItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCheckDataParityItem = Mapper.Map(command);
            await _unitOfWork.CheckDataParityItemRepository.AddAsync(newCheckDataParityItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCheckDataParityItemCommand command)
        {

            command.Validate();

            var CheckDataParityItem = await _unitOfWork.CheckDataParityItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CheckDataParityItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CheckDataParityItem = Mapper.Map(CheckDataParityItem, command);
            CheckDataParityItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CheckDataParityItem = await _unitOfWork.CheckDataParityItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CheckDataParityItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CheckDataParityItem.IsActive = false;
            CheckDataParityItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CheckDataParityItems = await _unitOfWork.CheckDataParityItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CheckDataParityItemsDto = Mapper.Map(CheckDataParityItems);

            return OkResult(CustomMessage.DefaultMessage, CheckDataParityItemsDto.ToPagingAndSorting(query), CheckDataParityItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CheckDataParityItem = await _unitOfWork.CheckDataParityItemRepository.GetByIdAsync(id);

            if (CheckDataParityItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CheckDataParityItemDto = Mapper.Map(CheckDataParityItem);

            return OkResult( CustomMessage.DefaultMessage , CheckDataParityItemDto);

        }
    }
}
