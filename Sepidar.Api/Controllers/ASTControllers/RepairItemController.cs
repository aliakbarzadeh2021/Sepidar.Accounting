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

namespace Sepidar.Api.Controllers.RepairItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class RepairItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RepairItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddRepairItemCommand command)
        {
            command.Validate();

            var RepairItems = await _unitOfWork.RepairItemRepository.FindAsync(c => c.Id == command.Id);

            if (RepairItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newRepairItem = Mapper.Map(command);
            await _unitOfWork.RepairItemRepository.AddAsync(newRepairItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditRepairItemCommand command)
        {

            command.Validate();

            var RepairItem = await _unitOfWork.RepairItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (RepairItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            RepairItem = Mapper.Map(RepairItem, command);
            RepairItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var RepairItem = await _unitOfWork.RepairItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (RepairItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            RepairItem.IsActive = false;
            RepairItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var RepairItems = await _unitOfWork.RepairItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var RepairItemsDto = Mapper.Map(RepairItems);

            return OkResult(CustomMessage.DefaultMessage, RepairItemsDto.ToPagingAndSorting(query), RepairItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var RepairItem = await _unitOfWork.RepairItemRepository.GetByIdAsync(id);

            if (RepairItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var RepairItemDto = Mapper.Map(RepairItem);

            return OkResult( CustomMessage.DefaultMessage , RepairItemDto);

        }
    }
}
