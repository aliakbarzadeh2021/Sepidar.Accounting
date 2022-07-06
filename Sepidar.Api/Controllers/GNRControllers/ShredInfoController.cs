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

namespace Sepidar.Api.Controllers.ShredInfoControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShredInfoController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShredInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddShredInfoCommand command)
        {
            command.Validate();

            var ShredInfos = await _unitOfWork.ShredInfoRepository.FindAsync(c => c.Id == command.Id);

            if (ShredInfos.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newShredInfo = Mapper.Map(command);
            await _unitOfWork.ShredInfoRepository.AddAsync(newShredInfo);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditShredInfoCommand command)
        {

            command.Validate();

            var ShredInfo = await _unitOfWork.ShredInfoRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ShredInfo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShredInfo = Mapper.Map(ShredInfo, command);
            ShredInfo.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ShredInfo = await _unitOfWork.ShredInfoRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ShredInfo == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ShredInfo.IsActive = false;
            ShredInfo.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ShredInfos = await _unitOfWork.ShredInfoRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ShredInfosDto = Mapper.Map(ShredInfos);

            return OkResult(CustomMessage.DefaultMessage, ShredInfosDto.ToPagingAndSorting(query), ShredInfosDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ShredInfo = await _unitOfWork.ShredInfoRepository.GetByIdAsync(id);

            if (ShredInfo is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ShredInfoDto = Mapper.Map(ShredInfo);

            return OkResult( CustomMessage.DefaultMessage , ShredInfoDto);

        }
    }
}
