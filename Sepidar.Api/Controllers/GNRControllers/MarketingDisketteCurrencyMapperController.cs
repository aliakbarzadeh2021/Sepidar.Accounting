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

namespace Sepidar.Api.Controllers.MarketingDisketteCurrencyMapperControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MarketingDisketteCurrencyMapperController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MarketingDisketteCurrencyMapperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMarketingDisketteCurrencyMapperCommand command)
        {
            command.Validate();

            var MarketingDisketteCurrencyMappers = await _unitOfWork.MarketingDisketteCurrencyMapperRepository.FindAsync(c => c.Id == command.Id);

            if (MarketingDisketteCurrencyMappers.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newMarketingDisketteCurrencyMapper = Mapper.Map(command);
            await _unitOfWork.MarketingDisketteCurrencyMapperRepository.AddAsync(newMarketingDisketteCurrencyMapper);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditMarketingDisketteCurrencyMapperCommand command)
        {

            command.Validate();

            var MarketingDisketteCurrencyMapper = await _unitOfWork.MarketingDisketteCurrencyMapperRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (MarketingDisketteCurrencyMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDisketteCurrencyMapper = Mapper.Map(MarketingDisketteCurrencyMapper, command);
            MarketingDisketteCurrencyMapper.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var MarketingDisketteCurrencyMapper = await _unitOfWork.MarketingDisketteCurrencyMapperRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (MarketingDisketteCurrencyMapper == null)
                return NotFound(CustomMessage.NotFoundMessage);

            MarketingDisketteCurrencyMapper.IsActive = false;
            MarketingDisketteCurrencyMapper.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var MarketingDisketteCurrencyMappers = await _unitOfWork.MarketingDisketteCurrencyMapperRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var MarketingDisketteCurrencyMappersDto = Mapper.Map(MarketingDisketteCurrencyMappers);

            return OkResult(CustomMessage.DefaultMessage, MarketingDisketteCurrencyMappersDto.ToPagingAndSorting(query), MarketingDisketteCurrencyMappersDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var MarketingDisketteCurrencyMapper = await _unitOfWork.MarketingDisketteCurrencyMapperRepository.GetByIdAsync(id);

            if (MarketingDisketteCurrencyMapper is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var MarketingDisketteCurrencyMapperDto = Mapper.Map(MarketingDisketteCurrencyMapper);

            return OkResult( CustomMessage.DefaultMessage , MarketingDisketteCurrencyMapperDto);

        }
    }
}
