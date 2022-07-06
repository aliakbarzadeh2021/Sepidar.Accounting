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

namespace Sepidar.Api.Controllers.CommissionCalculationItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionCalculationItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommissionCalculationItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommissionCalculationItemCommand command)
        {
            command.Validate();

            var CommissionCalculationItems = await _unitOfWork.CommissionCalculationItemRepository.FindAsync(c => c.Id == command.Id);

            if (CommissionCalculationItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommissionCalculationItem = Mapper.Map(command);
            await _unitOfWork.CommissionCalculationItemRepository.AddAsync(newCommissionCalculationItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommissionCalculationItemCommand command)
        {

            command.Validate();

            var CommissionCalculationItem = await _unitOfWork.CommissionCalculationItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CommissionCalculationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionCalculationItem = Mapper.Map(CommissionCalculationItem, command);
            CommissionCalculationItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CommissionCalculationItem = await _unitOfWork.CommissionCalculationItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CommissionCalculationItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CommissionCalculationItem.IsActive = false;
            CommissionCalculationItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CommissionCalculationItems = await _unitOfWork.CommissionCalculationItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommissionCalculationItemsDto = Mapper.Map(CommissionCalculationItems);

            return OkResult(CustomMessage.DefaultMessage, CommissionCalculationItemsDto.ToPagingAndSorting(query), CommissionCalculationItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CommissionCalculationItem = await _unitOfWork.CommissionCalculationItemRepository.GetByIdAsync(id);

            if (CommissionCalculationItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommissionCalculationItemDto = Mapper.Map(CommissionCalculationItem);

            return OkResult( CustomMessage.DefaultMessage , CommissionCalculationItemDto);

        }
    }
}
