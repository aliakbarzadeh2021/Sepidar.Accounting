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

namespace Sepidar.Api.Controllers.AssetGroupControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AssetGroupController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssetGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAssetGroupCommand command)
        {
            command.Validate();

            var AssetGroups = await _unitOfWork.AssetGroupRepository.FindAsync(c => c.Id == command.Id);

            if (AssetGroups.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAssetGroup = Mapper.Map(command);
            await _unitOfWork.AssetGroupRepository.AddAsync(newAssetGroup);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAssetGroupCommand command)
        {

            command.Validate();

            var AssetGroup = await _unitOfWork.AssetGroupRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AssetGroup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AssetGroup = Mapper.Map(AssetGroup, command);
            AssetGroup.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AssetGroup = await _unitOfWork.AssetGroupRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AssetGroup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AssetGroup.IsActive = false;
            AssetGroup.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AssetGroups = await _unitOfWork.AssetGroupRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AssetGroupsDto = Mapper.Map(AssetGroups);

            return OkResult(CustomMessage.DefaultMessage, AssetGroupsDto.ToPagingAndSorting(query), AssetGroupsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AssetGroup = await _unitOfWork.AssetGroupRepository.GetByIdAsync(id);

            if (AssetGroup is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AssetGroupDto = Mapper.Map(AssetGroup);

            return OkResult( CustomMessage.DefaultMessage , AssetGroupDto);

        }
    }
}
