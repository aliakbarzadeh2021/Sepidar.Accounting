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

namespace Sepidar.Api.Controllers.KeywordControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class KeywordController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public KeywordController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddKeywordCommand command)
        {
            command.Validate();

            var Keywords = await _unitOfWork.KeywordRepository.FindAsync(c => c.Id == command.Id);

            if (Keywords.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newKeyword = Mapper.Map(command);
            await _unitOfWork.KeywordRepository.AddAsync(newKeyword);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditKeywordCommand command)
        {

            command.Validate();

            var Keyword = await _unitOfWork.KeywordRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Keyword == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Keyword = Mapper.Map(Keyword, command);
            Keyword.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Keyword = await _unitOfWork.KeywordRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Keyword == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Keyword.IsActive = false;
            Keyword.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Keywords = await _unitOfWork.KeywordRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var KeywordsDto = Mapper.Map(Keywords);

            return OkResult(CustomMessage.DefaultMessage, KeywordsDto.ToPagingAndSorting(query), KeywordsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Keyword = await _unitOfWork.KeywordRepository.GetByIdAsync(id);

            if (Keyword is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var KeywordDto = Mapper.Map(Keyword);

            return OkResult( CustomMessage.DefaultMessage , KeywordDto);

        }
    }
}
