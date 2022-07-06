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

namespace Sepidar.Api.Controllers.ProducedItemPriceControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProducedItemPriceController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProducedItemPriceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProducedItemPriceCommand command)
        {
            command.Validate();

            var ProducedItemPrices = await _unitOfWork.ProducedItemPriceRepository.FindAsync(c => c.Id == command.Id);

            if (ProducedItemPrices.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProducedItemPrice = Mapper.Map(command);
            await _unitOfWork.ProducedItemPriceRepository.AddAsync(newProducedItemPrice);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProducedItemPriceCommand command)
        {

            command.Validate();

            var ProducedItemPrice = await _unitOfWork.ProducedItemPriceRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProducedItemPrice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProducedItemPrice = Mapper.Map(ProducedItemPrice, command);
            ProducedItemPrice.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProducedItemPrice = await _unitOfWork.ProducedItemPriceRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProducedItemPrice == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProducedItemPrice.IsActive = false;
            ProducedItemPrice.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProducedItemPrices = await _unitOfWork.ProducedItemPriceRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProducedItemPricesDto = Mapper.Map(ProducedItemPrices);

            return OkResult(CustomMessage.DefaultMessage, ProducedItemPricesDto.ToPagingAndSorting(query), ProducedItemPricesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProducedItemPrice = await _unitOfWork.ProducedItemPriceRepository.GetByIdAsync(id);

            if (ProducedItemPrice is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProducedItemPriceDto = Mapper.Map(ProducedItemPrice);

            return OkResult( CustomMessage.DefaultMessage , ProducedItemPriceDto);

        }
    }
}
