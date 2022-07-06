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

namespace Sepidar.Api.Controllers.PropertyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PropertyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPropertyCommand command)
        {
            command.Validate();

            var Propertys = await _unitOfWork.PropertyRepository.FindAsync(c => c.Id == command.Id);

            if (Propertys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProperty = Mapper.Map(command);
            await _unitOfWork.PropertyRepository.AddAsync(newProperty);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPropertyCommand command)
        {

            command.Validate();

            var Property = await _unitOfWork.PropertyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Property == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Property = Mapper.Map(Property, command);
            Property.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Property = await _unitOfWork.PropertyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Property == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Property.IsActive = false;
            Property.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Propertys = await _unitOfWork.PropertyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PropertysDto = Mapper.Map(Propertys);

            return OkResult(CustomMessage.DefaultMessage, PropertysDto.ToPagingAndSorting(query), PropertysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Property = await _unitOfWork.PropertyRepository.GetByIdAsync(id);

            if (Property is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PropertyDto = Mapper.Map(Property);

            return OkResult( CustomMessage.DefaultMessage , PropertyDto);

        }
    }
}
