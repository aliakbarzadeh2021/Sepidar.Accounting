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

namespace Sepidar.Api.Controllers.CompoundBarcodeControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CompoundBarcodeController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompoundBarcodeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCompoundBarcodeCommand command)
        {
            command.Validate();

            var CompoundBarcodes = await _unitOfWork.CompoundBarcodeRepository.FindAsync(c => c.Id == command.Id);

            if (CompoundBarcodes.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCompoundBarcode = Mapper.Map(command);
            await _unitOfWork.CompoundBarcodeRepository.AddAsync(newCompoundBarcode);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCompoundBarcodeCommand command)
        {

            command.Validate();

            var CompoundBarcode = await _unitOfWork.CompoundBarcodeRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (CompoundBarcode == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CompoundBarcode = Mapper.Map(CompoundBarcode, command);
            CompoundBarcode.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var CompoundBarcode = await _unitOfWork.CompoundBarcodeRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (CompoundBarcode == null)
                return NotFound(CustomMessage.NotFoundMessage);

            CompoundBarcode.IsActive = false;
            CompoundBarcode.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var CompoundBarcodes = await _unitOfWork.CompoundBarcodeRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CompoundBarcodesDto = Mapper.Map(CompoundBarcodes);

            return OkResult(CustomMessage.DefaultMessage, CompoundBarcodesDto.ToPagingAndSorting(query), CompoundBarcodesDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var CompoundBarcode = await _unitOfWork.CompoundBarcodeRepository.GetByIdAsync(id);

            if (CompoundBarcode is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CompoundBarcodeDto = Mapper.Map(CompoundBarcode);

            return OkResult( CustomMessage.DefaultMessage , CompoundBarcodeDto);

        }
    }
}
