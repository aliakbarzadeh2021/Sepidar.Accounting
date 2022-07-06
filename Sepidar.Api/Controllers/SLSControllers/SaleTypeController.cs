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

namespace Sepidar.Api.Controllers.SaleTypeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SaleTypeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SaleTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSaleTypeCommand command)
        {
            command.Validate();

            var SaleTypes = await _unitOfWork.SaleTypeRepository.FindAsync(c => c.Id == command.Id);

            if (SaleTypes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSaleType = Mapper.Map(command);
            await _unitOfWork.SaleTypeRepository.AddAsync(newSaleType);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSaleTypeCommand command)
        {

            command.Validate();

            var SaleType = await _unitOfWork.SaleTypeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SaleType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SaleType = Mapper.Map(SaleType, command);
            SaleType.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SaleType = await _unitOfWork.SaleTypeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SaleType == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SaleType.IsActive = false;
            SaleType.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SaleTypes = await _unitOfWork.SaleTypeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SaleTypesDto = Mapper.Map(SaleTypes);

            return OkResult(CustomMessage.DefaultMessage, SaleTypesDto.ToPagingAndSorting(query), SaleTypesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SaleType = await _unitOfWork.SaleTypeRepository.GetByIdAsync(id);

            if (SaleType is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SaleTypeDto = Mapper.Map(SaleType);

            return OkResult( CustomMessage.DefaultMessage , SaleTypeDto);

        }
    }
}
