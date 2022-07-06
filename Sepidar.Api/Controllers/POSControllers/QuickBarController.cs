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

namespace Sepidar.Api.Controllers.QuickBarControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QuickBarController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuickBarController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddQuickBarCommand command)
        {
            command.Validate();

            var QuickBars = await _unitOfWork.QuickBarRepository.FindAsync(c => c.Id == command.Id);

            if (QuickBars.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newQuickBar = Mapper.Map(command);
            await _unitOfWork.QuickBarRepository.AddAsync(newQuickBar);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditQuickBarCommand command)
        {

            command.Validate();

            var QuickBar = await _unitOfWork.QuickBarRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (QuickBar == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuickBar = Mapper.Map(QuickBar, command);
            QuickBar.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var QuickBar = await _unitOfWork.QuickBarRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (QuickBar == null)
                return NotFound(CustomMessage.NotFoundMessage);

            QuickBar.IsActive = false;
            QuickBar.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var QuickBars = await _unitOfWork.QuickBarRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var QuickBarsDto = Mapper.Map(QuickBars);

            return OkResult(CustomMessage.DefaultMessage, QuickBarsDto.ToPagingAndSorting(query), QuickBarsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var QuickBar = await _unitOfWork.QuickBarRepository.GetByIdAsync(id);

            if (QuickBar is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var QuickBarDto = Mapper.Map(QuickBar);

            return OkResult( CustomMessage.DefaultMessage , QuickBarDto);

        }
    }
}
