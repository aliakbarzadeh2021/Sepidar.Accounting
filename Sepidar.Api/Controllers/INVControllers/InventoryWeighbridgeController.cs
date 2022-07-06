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

namespace Sepidar.Api.Controllers.InventoryWeighbridgeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryWeighbridgeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryWeighbridgeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryWeighbridgeCommand command)
        {
            command.Validate();

            var InventoryWeighbridges = await _unitOfWork.InventoryWeighbridgeRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryWeighbridges.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryWeighbridge = Mapper.Map(command);
            await _unitOfWork.InventoryWeighbridgeRepository.AddAsync(newInventoryWeighbridge);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryWeighbridgeCommand command)
        {

            command.Validate();

            var InventoryWeighbridge = await _unitOfWork.InventoryWeighbridgeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryWeighbridge == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryWeighbridge = Mapper.Map(InventoryWeighbridge, command);
            InventoryWeighbridge.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryWeighbridge = await _unitOfWork.InventoryWeighbridgeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryWeighbridge == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryWeighbridge.IsActive = false;
            InventoryWeighbridge.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryWeighbridges = await _unitOfWork.InventoryWeighbridgeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryWeighbridgesDto = Mapper.Map(InventoryWeighbridges);

            return OkResult(CustomMessage.DefaultMessage, InventoryWeighbridgesDto.ToPagingAndSorting(query), InventoryWeighbridgesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryWeighbridge = await _unitOfWork.InventoryWeighbridgeRepository.GetByIdAsync(id);

            if (InventoryWeighbridge is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryWeighbridgeDto = Mapper.Map(InventoryWeighbridge);

            return OkResult( CustomMessage.DefaultMessage , InventoryWeighbridgeDto);

        }
    }
}
