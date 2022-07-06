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

namespace Sepidar.Api.Controllers.SalesLimitControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SalesLimitController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalesLimitController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSalesLimitCommand command)
        {
            command.Validate();

            var SalesLimits = await _unitOfWork.SalesLimitRepository.FindAsync(c => c.Id == command.Id);

            if (SalesLimits.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSalesLimit = Mapper.Map(command);
            await _unitOfWork.SalesLimitRepository.AddAsync(newSalesLimit);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSalesLimitCommand command)
        {

            command.Validate();

            var SalesLimit = await _unitOfWork.SalesLimitRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SalesLimit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SalesLimit = Mapper.Map(SalesLimit, command);
            SalesLimit.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SalesLimit = await _unitOfWork.SalesLimitRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SalesLimit == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SalesLimit.IsActive = false;
            SalesLimit.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SalesLimits = await _unitOfWork.SalesLimitRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SalesLimitsDto = Mapper.Map(SalesLimits);

            return OkResult(CustomMessage.DefaultMessage, SalesLimitsDto.ToPagingAndSorting(query), SalesLimitsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SalesLimit = await _unitOfWork.SalesLimitRepository.GetByIdAsync(id);

            if (SalesLimit is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SalesLimitDto = Mapper.Map(SalesLimit);

            return OkResult( CustomMessage.DefaultMessage , SalesLimitDto);

        }
    }
}
