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

namespace Sepidar.Api.Controllers.MonthlyDataControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MonthlyDataController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MonthlyDataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMonthlyDataCommand command)
        {
            command.Validate();

            var MonthlyDatas = await _unitOfWork.MonthlyDataRepository.FindAsync(c => c.Id == command.Id);

            if (MonthlyDatas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMonthlyData = Mapper.Map(command);
            await _unitOfWork.MonthlyDataRepository.AddAsync(newMonthlyData);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMonthlyDataCommand command)
        {

            command.Validate();

            var MonthlyData = await _unitOfWork.MonthlyDataRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MonthlyData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MonthlyData = Mapper.Map(MonthlyData, command);
            MonthlyData.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MonthlyData = await _unitOfWork.MonthlyDataRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MonthlyData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MonthlyData.IsActive = false;
            MonthlyData.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MonthlyDatas = await _unitOfWork.MonthlyDataRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MonthlyDatasDto = Mapper.Map(MonthlyDatas);

            return OkResult(CustomMessage.DefaultMessage, MonthlyDatasDto.ToPagingAndSorting(query), MonthlyDatasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MonthlyData = await _unitOfWork.MonthlyDataRepository.GetByIdAsync(id);

            if (MonthlyData is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MonthlyDataDto = Mapper.Map(MonthlyData);

            return OkResult( CustomMessage.DefaultMessage , MonthlyDataDto);

        }
    }
}
