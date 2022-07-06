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

namespace Sepidar.Api.Controllers.PhoneLineControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PhoneLineController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PhoneLineController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPhoneLineCommand command)
        {
            command.Validate();

            var PhoneLines = await _unitOfWork.PhoneLineRepository.FindAsync(c => c.Id == command.Id);

            if (PhoneLines.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPhoneLine = Mapper.Map(command);
            await _unitOfWork.PhoneLineRepository.AddAsync(newPhoneLine);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPhoneLineCommand command)
        {

            command.Validate();

            var PhoneLine = await _unitOfWork.PhoneLineRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PhoneLine == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PhoneLine = Mapper.Map(PhoneLine, command);
            PhoneLine.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PhoneLine = await _unitOfWork.PhoneLineRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PhoneLine == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PhoneLine.IsActive = false;
            PhoneLine.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PhoneLines = await _unitOfWork.PhoneLineRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PhoneLinesDto = Mapper.Map(PhoneLines);

            return OkResult(CustomMessage.DefaultMessage, PhoneLinesDto.ToPagingAndSorting(query), PhoneLinesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PhoneLine = await _unitOfWork.PhoneLineRepository.GetByIdAsync(id);

            if (PhoneLine is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PhoneLineDto = Mapper.Map(PhoneLine);

            return OkResult( CustomMessage.DefaultMessage , PhoneLineDto);

        }
    }
}
