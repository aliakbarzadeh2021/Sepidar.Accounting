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

namespace Sepidar.Api.Controllers.KeywordLocaleControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class KeywordLocaleController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public KeywordLocaleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddKeywordLocaleCommand command)
        {
            command.Validate();

            var KeywordLocales = await _unitOfWork.KeywordLocaleRepository.FindAsync(c => c.Id == command.Id);

            if (KeywordLocales.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newKeywordLocale = Mapper.Map(command);
            await _unitOfWork.KeywordLocaleRepository.AddAsync(newKeywordLocale);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditKeywordLocaleCommand command)
        {

            command.Validate();

            var KeywordLocale = await _unitOfWork.KeywordLocaleRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (KeywordLocale == null)
                return NotFound(CustomMessage.NotFoundMessage);

            KeywordLocale = Mapper.Map(KeywordLocale, command);
            KeywordLocale.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var KeywordLocale = await _unitOfWork.KeywordLocaleRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (KeywordLocale == null)
                return NotFound(CustomMessage.NotFoundMessage);

            KeywordLocale.IsActive = false;
            KeywordLocale.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var KeywordLocales = await _unitOfWork.KeywordLocaleRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var KeywordLocalesDto = Mapper.Map(KeywordLocales);

            return OkResult(CustomMessage.DefaultMessage, KeywordLocalesDto.ToPagingAndSorting(query), KeywordLocalesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var KeywordLocale = await _unitOfWork.KeywordLocaleRepository.GetByIdAsync(id);

            if (KeywordLocale is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var KeywordLocaleDto = Mapper.Map(KeywordLocale);

            return OkResult( CustomMessage.DefaultMessage , KeywordLocaleDto);

        }
    }
}
