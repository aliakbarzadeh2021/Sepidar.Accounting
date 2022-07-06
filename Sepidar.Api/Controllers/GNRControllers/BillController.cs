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

namespace Sepidar.Api.Controllers.BillControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BillController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BillController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBillCommand command)
        {
            command.Validate();

            var Bills = await _unitOfWork.BillRepository.FindAsync(c => c.Id == command.Id);

            if (Bills.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBill = Mapper.Map(command);
            await _unitOfWork.BillRepository.AddAsync(newBill);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBillCommand command)
        {

            command.Validate();

            var Bill = await _unitOfWork.BillRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Bill == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Bill = Mapper.Map(Bill, command);
            Bill.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Bill = await _unitOfWork.BillRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Bill == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Bill.IsActive = false;
            Bill.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Bills = await _unitOfWork.BillRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BillsDto = Mapper.Map(Bills);

            return OkResult(CustomMessage.DefaultMessage, BillsDto.ToPagingAndSorting(query), BillsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Bill = await _unitOfWork.BillRepository.GetByIdAsync(id);

            if (Bill is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BillDto = Mapper.Map(Bill);

            return OkResult( CustomMessage.DefaultMessage , BillDto);

        }
    }
}
