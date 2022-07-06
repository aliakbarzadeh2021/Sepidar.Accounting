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

namespace Sepidar.Api.Controllers.WarrantyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WarrantyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public WarrantyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddWarrantyCommand command)
        {
            command.Validate();

            var Warrantys = await _unitOfWork.WarrantyRepository.FindAsync(c => c.Id == command.Id);

            if (Warrantys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newWarranty = Mapper.Map(command);
            await _unitOfWork.WarrantyRepository.AddAsync(newWarranty);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditWarrantyCommand command)
        {

            command.Validate();

            var Warranty = await _unitOfWork.WarrantyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Warranty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Warranty = Mapper.Map(Warranty, command);
            Warranty.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Warranty = await _unitOfWork.WarrantyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Warranty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Warranty.IsActive = false;
            Warranty.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Warrantys = await _unitOfWork.WarrantyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var WarrantysDto = Mapper.Map(Warrantys);

            return OkResult(CustomMessage.DefaultMessage, WarrantysDto.ToPagingAndSorting(query), WarrantysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Warranty = await _unitOfWork.WarrantyRepository.GetByIdAsync(id);

            if (Warranty is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var WarrantyDto = Mapper.Map(Warranty);

            return OkResult( CustomMessage.DefaultMessage , WarrantyDto);

        }
    }
}
