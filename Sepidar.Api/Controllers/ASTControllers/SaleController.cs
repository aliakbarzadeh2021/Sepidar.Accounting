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

namespace Sepidar.Api.Controllers.SaleControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SaleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSaleCommand command)
        {
            command.Validate();

            var Sales = await _unitOfWork.SaleRepository.FindAsync(c => c.Id == command.Id);

            if (Sales.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSale = Mapper.Map(command);
            await _unitOfWork.SaleRepository.AddAsync(newSale);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSaleCommand command)
        {

            command.Validate();

            var Sale = await _unitOfWork.SaleRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Sale == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Sale = Mapper.Map(Sale, command);
            Sale.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Sale = await _unitOfWork.SaleRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Sale == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Sale.IsActive = false;
            Sale.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Sales = await _unitOfWork.SaleRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SalesDto = Mapper.Map(Sales);

            return OkResult(CustomMessage.DefaultMessage, SalesDto.ToPagingAndSorting(query), SalesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Sale = await _unitOfWork.SaleRepository.GetByIdAsync(id);

            if (Sale is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SaleDto = Mapper.Map(Sale);

            return OkResult( CustomMessage.DefaultMessage , SaleDto);

        }
    }
}
