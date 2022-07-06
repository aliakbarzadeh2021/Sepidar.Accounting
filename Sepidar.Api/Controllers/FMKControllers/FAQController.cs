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

namespace Sepidar.Api.Controllers.FAQControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class FAQController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FAQController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddFAQCommand command)
        {
            command.Validate();

            var FAQs = await _unitOfWork.FAQRepository.FindAsync(c => c.Id == command.Id);

            if (FAQs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newFAQ = Mapper.Map(command);
            await _unitOfWork.FAQRepository.AddAsync(newFAQ);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditFAQCommand command)
        {

            command.Validate();

            var FAQ = await _unitOfWork.FAQRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (FAQ == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FAQ = Mapper.Map(FAQ, command);
            FAQ.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var FAQ = await _unitOfWork.FAQRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (FAQ == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FAQ.IsActive = false;
            FAQ.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var FAQs = await _unitOfWork.FAQRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var FAQsDto = Mapper.Map(FAQs);

            return OkResult(CustomMessage.DefaultMessage, FAQsDto.ToPagingAndSorting(query), FAQsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var FAQ = await _unitOfWork.FAQRepository.GetByIdAsync(id);

            if (FAQ is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var FAQDto = Mapper.Map(FAQ);

            return OkResult( CustomMessage.DefaultMessage , FAQDto);

        }
    }
}
