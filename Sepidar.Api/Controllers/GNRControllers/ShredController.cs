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

namespace Sepidar.Api.Controllers.ShredControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShredController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShredController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddShredCommand command)
        {
            command.Validate();

            var Shreds = await _unitOfWork.ShredRepository.FindAsync(c => c.Id == command.Id);

            if (Shreds.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newShred = Mapper.Map(command);
            await _unitOfWork.ShredRepository.AddAsync(newShred);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditShredCommand command)
        {

            command.Validate();

            var Shred = await _unitOfWork.ShredRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Shred == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Shred = Mapper.Map(Shred, command);
            Shred.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Shred = await _unitOfWork.ShredRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Shred == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Shred.IsActive = false;
            Shred.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Shreds = await _unitOfWork.ShredRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ShredsDto = Mapper.Map(Shreds);

            return OkResult(CustomMessage.DefaultMessage, ShredsDto.ToPagingAndSorting(query), ShredsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Shred = await _unitOfWork.ShredRepository.GetByIdAsync(id);

            if (Shred is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ShredDto = Mapper.Map(Shred);

            return OkResult( CustomMessage.DefaultMessage , ShredDto);

        }
    }
}
