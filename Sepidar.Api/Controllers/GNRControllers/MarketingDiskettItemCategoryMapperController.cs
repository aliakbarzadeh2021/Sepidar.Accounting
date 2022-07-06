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

namespace Sepidar.Api.Controllers.MarketingDiskettItemCategoryMapperControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MarketingDiskettItemCategoryMapperController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarketingDiskettItemCategoryMapperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMarketingDiskettItemCategoryMapperCommand command)
        {
            command.Validate();

            var MarketingDiskettItemCategoryMappers = await _unitOfWork.MarketingDiskettItemCategoryMapperRepository.FindAsync(c => c.Id == command.Id);

            if (MarketingDiskettItemCategoryMappers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMarketingDiskettItemCategoryMapper = Mapper.Map(command);
            await _unitOfWork.MarketingDiskettItemCategoryMapperRepository.AddAsync(newMarketingDiskettItemCategoryMapper);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMarketingDiskettItemCategoryMapperCommand command)
        {

            command.Validate();

            var MarketingDiskettItemCategoryMapper = await _unitOfWork.MarketingDiskettItemCategoryMapperRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MarketingDiskettItemCategoryMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDiskettItemCategoryMapper = Mapper.Map(MarketingDiskettItemCategoryMapper, command);
            MarketingDiskettItemCategoryMapper.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MarketingDiskettItemCategoryMapper = await _unitOfWork.MarketingDiskettItemCategoryMapperRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MarketingDiskettItemCategoryMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDiskettItemCategoryMapper.IsActive = false;
            MarketingDiskettItemCategoryMapper.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MarketingDiskettItemCategoryMappers = await _unitOfWork.MarketingDiskettItemCategoryMapperRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MarketingDiskettItemCategoryMappersDto = Mapper.Map(MarketingDiskettItemCategoryMappers);

            return OkResult(CustomMessage.DefaultMessage, MarketingDiskettItemCategoryMappersDto.ToPagingAndSorting(query), MarketingDiskettItemCategoryMappersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MarketingDiskettItemCategoryMapper = await _unitOfWork.MarketingDiskettItemCategoryMapperRepository.GetByIdAsync(id);

            if (MarketingDiskettItemCategoryMapper is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MarketingDiskettItemCategoryMapperDto = Mapper.Map(MarketingDiskettItemCategoryMapper);

            return OkResult( CustomMessage.DefaultMessage , MarketingDiskettItemCategoryMapperDto);

        }
    }
}
