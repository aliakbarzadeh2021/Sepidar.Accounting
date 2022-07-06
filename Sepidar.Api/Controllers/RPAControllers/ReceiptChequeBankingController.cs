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

namespace Sepidar.Api.Controllers.ReceiptChequeBankingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReceiptChequeBankingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReceiptChequeBankingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReceiptChequeBankingCommand command)
        {
            command.Validate();

            var ReceiptChequeBankings = await _unitOfWork.ReceiptChequeBankingRepository.FindAsync(c => c.Id == command.Id);

            if (ReceiptChequeBankings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReceiptChequeBanking = Mapper.Map(command);
            await _unitOfWork.ReceiptChequeBankingRepository.AddAsync(newReceiptChequeBanking);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReceiptChequeBankingCommand command)
        {

            command.Validate();

            var ReceiptChequeBanking = await _unitOfWork.ReceiptChequeBankingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ReceiptChequeBanking == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptChequeBanking = Mapper.Map(ReceiptChequeBanking, command);
            ReceiptChequeBanking.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ReceiptChequeBanking = await _unitOfWork.ReceiptChequeBankingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ReceiptChequeBanking == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ReceiptChequeBanking.IsActive = false;
            ReceiptChequeBanking.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ReceiptChequeBankings = await _unitOfWork.ReceiptChequeBankingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReceiptChequeBankingsDto = Mapper.Map(ReceiptChequeBankings);

            return OkResult(CustomMessage.DefaultMessage, ReceiptChequeBankingsDto.ToPagingAndSorting(query), ReceiptChequeBankingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ReceiptChequeBanking = await _unitOfWork.ReceiptChequeBankingRepository.GetByIdAsync(id);

            if (ReceiptChequeBanking is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReceiptChequeBankingDto = Mapper.Map(ReceiptChequeBanking);

            return OkResult( CustomMessage.DefaultMessage , ReceiptChequeBankingDto);

        }
    }
}
