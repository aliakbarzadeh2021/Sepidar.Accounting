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

namespace Sepidar.Api.Controllers.CashierControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CashierController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CashierController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCashierCommand command)
        {
            command.Validate();

            var Cashiers = await _unitOfWork.CashierRepository.FindAsync(c => c.Id == command.Id);

            if (Cashiers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCashier = Mapper.Map(command);
            await _unitOfWork.CashierRepository.AddAsync(newCashier);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCashierCommand command)
        {

            command.Validate();

            var Cashier = await _unitOfWork.CashierRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Cashier == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Cashier = Mapper.Map(Cashier, command);
            Cashier.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Cashier = await _unitOfWork.CashierRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Cashier == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Cashier.IsActive = false;
            Cashier.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Cashiers = await _unitOfWork.CashierRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CashiersDto = Mapper.Map(Cashiers);

            return OkResult(CustomMessage.DefaultMessage, CashiersDto.ToPagingAndSorting(query), CashiersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Cashier = await _unitOfWork.CashierRepository.GetByIdAsync(id);

            if (Cashier is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CashierDto = Mapper.Map(Cashier);

            return OkResult( CustomMessage.DefaultMessage , CashierDto);

        }
    }
}
