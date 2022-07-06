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

namespace Sepidar.Api.Controllers.VatControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class VatController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public VatController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddVatCommand command)
        {
            command.Validate();

            var Vats = await _unitOfWork.VatRepository.FindAsync(c => c.Id == command.Id);

            if (Vats.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newVat = Mapper.Map(command);
            await _unitOfWork.VatRepository.AddAsync(newVat);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditVatCommand command)
        {

            command.Validate();

            var Vat = await _unitOfWork.VatRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Vat == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Vat = Mapper.Map(Vat, command);
            Vat.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Vat = await _unitOfWork.VatRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Vat == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Vat.IsActive = false;
            Vat.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Vats = await _unitOfWork.VatRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var VatsDto = Mapper.Map(Vats);

            return OkResult(CustomMessage.DefaultMessage, VatsDto.ToPagingAndSorting(query), VatsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Vat = await _unitOfWork.VatRepository.GetByIdAsync(id);

            if (Vat is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var VatDto = Mapper.Map(Vat);

            return OkResult( CustomMessage.DefaultMessage , VatDto);

        }
    }
}
