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

namespace Sepidar.Api.Controllers.ExtraDataControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ExtraDataController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ExtraDataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddExtraDataCommand command)
        {
            command.Validate();

            var ExtraDatas = await _unitOfWork.ExtraDataRepository.FindAsync(c => c.Id == command.Id);

            if (ExtraDatas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newExtraData = Mapper.Map(command);
            await _unitOfWork.ExtraDataRepository.AddAsync(newExtraData);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditExtraDataCommand command)
        {

            command.Validate();

            var ExtraData = await _unitOfWork.ExtraDataRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ExtraData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ExtraData = Mapper.Map(ExtraData, command);
            ExtraData.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ExtraData = await _unitOfWork.ExtraDataRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ExtraData == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ExtraData.IsActive = false;
            ExtraData.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ExtraDatas = await _unitOfWork.ExtraDataRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ExtraDatasDto = Mapper.Map(ExtraDatas);

            return OkResult(CustomMessage.DefaultMessage, ExtraDatasDto.ToPagingAndSorting(query), ExtraDatasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ExtraData = await _unitOfWork.ExtraDataRepository.GetByIdAsync(id);

            if (ExtraData is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ExtraDataDto = Mapper.Map(ExtraData);

            return OkResult( CustomMessage.DefaultMessage , ExtraDataDto);

        }
    }
}
