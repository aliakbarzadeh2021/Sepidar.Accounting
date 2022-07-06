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

namespace Sepidar.Api.Controllers.InventoryBalancingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryBalancingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryBalancingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInventoryBalancingCommand command)
        {
            command.Validate();

            var InventoryBalancings = await _unitOfWork.InventoryBalancingRepository.FindAsync(c => c.Id == command.Id);

            if (InventoryBalancings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInventoryBalancing = Mapper.Map(command);
            await _unitOfWork.InventoryBalancingRepository.AddAsync(newInventoryBalancing);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInventoryBalancingCommand command)
        {

            command.Validate();

            var InventoryBalancing = await _unitOfWork.InventoryBalancingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InventoryBalancing == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryBalancing = Mapper.Map(InventoryBalancing, command);
            InventoryBalancing.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InventoryBalancing = await _unitOfWork.InventoryBalancingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InventoryBalancing == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InventoryBalancing.IsActive = false;
            InventoryBalancing.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InventoryBalancings = await _unitOfWork.InventoryBalancingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InventoryBalancingsDto = Mapper.Map(InventoryBalancings);

            return OkResult(CustomMessage.DefaultMessage, InventoryBalancingsDto.ToPagingAndSorting(query), InventoryBalancingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InventoryBalancing = await _unitOfWork.InventoryBalancingRepository.GetByIdAsync(id);

            if (InventoryBalancing is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InventoryBalancingDto = Mapper.Map(InventoryBalancing);

            return OkResult( CustomMessage.DefaultMessage , InventoryBalancingDto);

        }
    }
}
