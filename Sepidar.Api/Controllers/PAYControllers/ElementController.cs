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

namespace Sepidar.Api.Controllers.ElementControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ElementController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ElementController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddElementCommand command)
        {
            command.Validate();

            var Elements = await _unitOfWork.ElementRepository.FindAsync(c => c.Id == command.Id);

            if (Elements.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newElement = Mapper.Map(command);
            await _unitOfWork.ElementRepository.AddAsync(newElement);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditElementCommand command)
        {

            command.Validate();

            var Element = await _unitOfWork.ElementRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Element == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Element = Mapper.Map(Element, command);
            Element.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Element = await _unitOfWork.ElementRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Element == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Element.IsActive = false;
            Element.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Elements = await _unitOfWork.ElementRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ElementsDto = Mapper.Map(Elements);

            return OkResult(CustomMessage.DefaultMessage, ElementsDto.ToPagingAndSorting(query), ElementsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Element = await _unitOfWork.ElementRepository.GetByIdAsync(id);

            if (Element is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ElementDto = Mapper.Map(Element);

            return OkResult( CustomMessage.DefaultMessage , ElementDto);

        }
    }
}
