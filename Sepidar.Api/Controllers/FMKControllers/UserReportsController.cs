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

namespace Sepidar.Api.Controllers.UserReportsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserReportsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserReportsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddUserReportsCommand command)
        {
            command.Validate();

            var UserReportss = await _unitOfWork.UserReportsRepository.FindAsync(c => c.Id == command.Id);

            if (UserReportss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newUserReports = Mapper.Map(command);
            await _unitOfWork.UserReportsRepository.AddAsync(newUserReports);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditUserReportsCommand command)
        {

            command.Validate();

            var UserReports = await _unitOfWork.UserReportsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (UserReports == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserReports = Mapper.Map(UserReports, command);
            UserReports.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var UserReports = await _unitOfWork.UserReportsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (UserReports == null)
                return NotFound(CustomMessage.NotFoundMessage);

            UserReports.IsActive = false;
            UserReports.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var UserReportss = await _unitOfWork.UserReportsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var UserReportssDto = Mapper.Map(UserReportss);

            return OkResult(CustomMessage.DefaultMessage, UserReportssDto.ToPagingAndSorting(query), UserReportssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var UserReports = await _unitOfWork.UserReportsRepository.GetByIdAsync(id);

            if (UserReports is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var UserReportsDto = Mapper.Map(UserReports);

            return OkResult( CustomMessage.DefaultMessage , UserReportsDto);

        }
    }
}
