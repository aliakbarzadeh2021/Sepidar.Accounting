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

namespace Sepidar.Api.Controllers.TenderControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TenderController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TenderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTenderCommand command)
        {
            command.Validate();

            var Tenders = await _unitOfWork.TenderRepository.FindAsync(c => c.Id == command.Id);

            if (Tenders.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTender = Mapper.Map(command);
            await _unitOfWork.TenderRepository.AddAsync(newTender);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTenderCommand command)
        {

            command.Validate();

            var Tender = await _unitOfWork.TenderRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Tender == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Tender = Mapper.Map(Tender, command);
            Tender.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Tender = await _unitOfWork.TenderRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Tender == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Tender.IsActive = false;
            Tender.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Tenders = await _unitOfWork.TenderRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TendersDto = Mapper.Map(Tenders);

            return OkResult(CustomMessage.DefaultMessage, TendersDto.ToPagingAndSorting(query), TendersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Tender = await _unitOfWork.TenderRepository.GetByIdAsync(id);

            if (Tender is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TenderDto = Mapper.Map(Tender);

            return OkResult( CustomMessage.DefaultMessage , TenderDto);

        }
    }
}
