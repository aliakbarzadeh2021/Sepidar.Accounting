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

namespace Sepidar.Api.Controllers.LookupLocaleControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LookupLocaleController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public LookupLocaleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddLookupLocaleCommand command)
        {
            command.Validate();

            var LookupLocales = await _unitOfWork.LookupLocaleRepository.FindAsync(c => c.Id == command.Id);

            if (LookupLocales.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newLookupLocale = Mapper.Map(command);
            await _unitOfWork.LookupLocaleRepository.AddAsync(newLookupLocale);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditLookupLocaleCommand command)
        {

            command.Validate();

            var LookupLocale = await _unitOfWork.LookupLocaleRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (LookupLocale == null)
                return NotFound(CustomMessage.NotFoundMessage);

            LookupLocale = Mapper.Map(LookupLocale, command);
            LookupLocale.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var LookupLocale = await _unitOfWork.LookupLocaleRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (LookupLocale == null)
                return NotFound(CustomMessage.NotFoundMessage);

            LookupLocale.IsActive = false;
            LookupLocale.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var LookupLocales = await _unitOfWork.LookupLocaleRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var LookupLocalesDto = Mapper.Map(LookupLocales);

            return OkResult(CustomMessage.DefaultMessage, LookupLocalesDto.ToPagingAndSorting(query), LookupLocalesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var LookupLocale = await _unitOfWork.LookupLocaleRepository.GetByIdAsync(id);

            if (LookupLocale is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var LookupLocaleDto = Mapper.Map(LookupLocale);

            return OkResult( CustomMessage.DefaultMessage , LookupLocaleDto);

        }
    }
}
