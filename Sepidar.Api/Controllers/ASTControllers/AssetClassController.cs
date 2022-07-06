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

namespace Sepidar.Api.Controllers.AssetClassControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AssetClassController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssetClassController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddAssetClassCommand command)
        {
            command.Validate();

            var AssetClasss = await _unitOfWork.AssetClassRepository.FindAsync(c => c.Id == command.Id);

            if (AssetClasss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newAssetClass = Mapper.Map(command);
            await _unitOfWork.AssetClassRepository.AddAsync(newAssetClass);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditAssetClassCommand command)
        {

            command.Validate();

            var AssetClass = await _unitOfWork.AssetClassRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (AssetClass == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AssetClass = Mapper.Map(AssetClass, command);
            AssetClass.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var AssetClass = await _unitOfWork.AssetClassRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (AssetClass == null)
                return NotFound(CustomMessage.NotFoundMessage);

            AssetClass.IsActive = false;
            AssetClass.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var AssetClasss = await _unitOfWork.AssetClassRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var AssetClasssDto = Mapper.Map(AssetClasss);

            return OkResult(CustomMessage.DefaultMessage, AssetClasssDto.ToPagingAndSorting(query), AssetClasssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var AssetClass = await _unitOfWork.AssetClassRepository.GetByIdAsync(id);

            if (AssetClass is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var AssetClassDto = Mapper.Map(AssetClass);

            return OkResult( CustomMessage.DefaultMessage , AssetClassDto);

        }
    }
}
