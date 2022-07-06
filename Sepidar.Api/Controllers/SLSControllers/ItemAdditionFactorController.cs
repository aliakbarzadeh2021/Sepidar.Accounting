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

namespace Sepidar.Api.Controllers.ItemAdditionFactorControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ItemAdditionFactorController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemAdditionFactorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddItemAdditionFactorCommand command)
        {
            command.Validate();

            var ItemAdditionFactors = await _unitOfWork.ItemAdditionFactorRepository.FindAsync(c => c.Id == command.Id);

            if (ItemAdditionFactors.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newItemAdditionFactor = Mapper.Map(command);
            await _unitOfWork.ItemAdditionFactorRepository.AddAsync(newItemAdditionFactor);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditItemAdditionFactorCommand command)
        {

            command.Validate();

            var ItemAdditionFactor = await _unitOfWork.ItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemAdditionFactor = Mapper.Map(ItemAdditionFactor, command);
            ItemAdditionFactor.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ItemAdditionFactor = await _unitOfWork.ItemAdditionFactorRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ItemAdditionFactor == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ItemAdditionFactor.IsActive = false;
            ItemAdditionFactor.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ItemAdditionFactors = await _unitOfWork.ItemAdditionFactorRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ItemAdditionFactorsDto = Mapper.Map(ItemAdditionFactors);

            return OkResult(CustomMessage.DefaultMessage, ItemAdditionFactorsDto.ToPagingAndSorting(query), ItemAdditionFactorsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ItemAdditionFactor = await _unitOfWork.ItemAdditionFactorRepository.GetByIdAsync(id);

            if (ItemAdditionFactor is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ItemAdditionFactorDto = Mapper.Map(ItemAdditionFactor);

            return OkResult( CustomMessage.DefaultMessage , ItemAdditionFactorDto);

        }
    }
}
