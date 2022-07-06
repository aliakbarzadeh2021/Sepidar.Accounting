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

namespace Sepidar.Api.Controllers.CustomContactPhoneControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CustomContactPhoneController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomContactPhoneController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCustomContactPhoneCommand command)
        {
            command.Validate();

            var CustomContactPhones = await _unitOfWork.CustomContactPhoneRepository.FindAsync(c => c.Id == command.Id);

            if (CustomContactPhones.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCustomContactPhone = Mapper.Map(command);
            await _unitOfWork.CustomContactPhoneRepository.AddAsync(newCustomContactPhone);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCustomContactPhoneCommand command)
        {

            command.Validate();

            var CustomContactPhone = await _unitOfWork.CustomContactPhoneRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CustomContactPhone == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CustomContactPhone = Mapper.Map(CustomContactPhone, command);
            CustomContactPhone.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CustomContactPhone = await _unitOfWork.CustomContactPhoneRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CustomContactPhone == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CustomContactPhone.IsActive = false;
            CustomContactPhone.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CustomContactPhones = await _unitOfWork.CustomContactPhoneRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CustomContactPhonesDto = Mapper.Map(CustomContactPhones);

            return OkResult(CustomMessage.DefaultMessage, CustomContactPhonesDto.ToPagingAndSorting(query), CustomContactPhonesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CustomContactPhone = await _unitOfWork.CustomContactPhoneRepository.GetByIdAsync(id);

            if (CustomContactPhone is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CustomContactPhoneDto = Mapper.Map(CustomContactPhone);

            return OkResult( CustomMessage.DefaultMessage , CustomContactPhoneDto);

        }
    }
}
