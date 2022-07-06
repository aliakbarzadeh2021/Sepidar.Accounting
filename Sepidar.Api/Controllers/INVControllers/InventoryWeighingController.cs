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

namespace Sepidar.Api.Controllers.InventoryWeighingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryWeighingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryWeighingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryWeighingCommand command)
        {
            command.Validate();

            var InventoryWeighings = await _unitOfWork.InventoryWeighingRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryWeighings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryWeighing = Mapper.Map(command);
            await _unitOfWork.InventoryWeighingRepository.AddAsync(newInventoryWeighing);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryWeighingCommand command)
        {

            command.Validate();

            var InventoryWeighing = await _unitOfWork.InventoryWeighingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryWeighing == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryWeighing = Mapper.Map(InventoryWeighing, command);
            InventoryWeighing.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryWeighing = await _unitOfWork.InventoryWeighingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryWeighing == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryWeighing.IsActive = false;
            InventoryWeighing.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryWeighings = await _unitOfWork.InventoryWeighingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryWeighingsDto = Mapper.Map(InventoryWeighings);

            return OkResult(CustomMessage.DefaultMessage, InventoryWeighingsDto.ToPagingAndSorting(query), InventoryWeighingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryWeighing = await _unitOfWork.InventoryWeighingRepository.GetByIdAsync(id);

            if (InventoryWeighing is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryWeighingDto = Mapper.Map(InventoryWeighing);

            return OkResult( CustomMessage.DefaultMessage , InventoryWeighingDto);

        }
    }
}
