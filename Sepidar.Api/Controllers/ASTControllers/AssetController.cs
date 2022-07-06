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

namespace Sepidar.Api.Controllers.AssetControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AssetController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAssetCommand command)
        {
            command.Validate();

            var Assets = await _unitOfWork.AssetRepository.FindAsync(c => c.Id == command.Id);

            if (Assets.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAsset = Mapper.Map(command);
            await _unitOfWork.AssetRepository.AddAsync(newAsset);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAssetCommand command)
        {

            command.Validate();

            var Asset = await _unitOfWork.AssetRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Asset == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Asset = Mapper.Map(Asset, command);
            Asset.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Asset = await _unitOfWork.AssetRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Asset == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Asset.IsActive = false;
            Asset.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Assets = await _unitOfWork.AssetRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AssetsDto = Mapper.Map(Assets);

            return OkResult(CustomMessage.DefaultMessage, AssetsDto.ToPagingAndSorting(query), AssetsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Asset = await _unitOfWork.AssetRepository.GetByIdAsync(id);

            if (Asset is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AssetDto = Mapper.Map(Asset);

            return OkResult( CustomMessage.DefaultMessage , AssetDto);

        }
    }
}
