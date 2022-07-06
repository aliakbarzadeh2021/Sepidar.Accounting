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

namespace Sepidar.Api.Controllers.CashControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CashController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CashController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCashCommand command)
        {
            command.Validate();

            var Cashs = await _unitOfWork.CashRepository.FindAsync(c => c.Id == command.Id);

            if (Cashs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCash = Mapper.Map(command);
            await _unitOfWork.CashRepository.AddAsync(newCash);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCashCommand command)
        {

            command.Validate();

            var Cash = await _unitOfWork.CashRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Cash == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Cash = Mapper.Map(Cash, command);
            Cash.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Cash = await _unitOfWork.CashRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Cash == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Cash.IsActive = false;
            Cash.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Cashs = await _unitOfWork.CashRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CashsDto = Mapper.Map(Cashs);

            return OkResult(CustomMessage.DefaultMessage, CashsDto.ToPagingAndSorting(query), CashsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Cash = await _unitOfWork.CashRepository.GetByIdAsync(id);

            if (Cash is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CashDto = Mapper.Map(Cash);

            return OkResult( CustomMessage.DefaultMessage , CashDto);

        }
    }
}
