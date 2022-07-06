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

namespace Sepidar.Api.Controllers.StatusCoefficientItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StatusCoefficientItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StatusCoefficientItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddStatusCoefficientItemCommand command)
        {
            command.Validate();

            var StatusCoefficientItems = await _unitOfWork.StatusCoefficientItemRepository.FindAsync(c => c.Id == command.Id);

            if (StatusCoefficientItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newStatusCoefficientItem = Mapper.Map(command);
            await _unitOfWork.StatusCoefficientItemRepository.AddAsync(newStatusCoefficientItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditStatusCoefficientItemCommand command)
        {

            command.Validate();

            var StatusCoefficientItem = await _unitOfWork.StatusCoefficientItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (StatusCoefficientItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StatusCoefficientItem = Mapper.Map(StatusCoefficientItem, command);
            StatusCoefficientItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var StatusCoefficientItem = await _unitOfWork.StatusCoefficientItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (StatusCoefficientItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            StatusCoefficientItem.IsActive = false;
            StatusCoefficientItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var StatusCoefficientItems = await _unitOfWork.StatusCoefficientItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var StatusCoefficientItemsDto = Mapper.Map(StatusCoefficientItems);

            return OkResult(CustomMessage.DefaultMessage, StatusCoefficientItemsDto.ToPagingAndSorting(query), StatusCoefficientItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var StatusCoefficientItem = await _unitOfWork.StatusCoefficientItemRepository.GetByIdAsync(id);

            if (StatusCoefficientItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var StatusCoefficientItemDto = Mapper.Map(StatusCoefficientItem);

            return OkResult( CustomMessage.DefaultMessage , StatusCoefficientItemDto);

        }
    }
}
