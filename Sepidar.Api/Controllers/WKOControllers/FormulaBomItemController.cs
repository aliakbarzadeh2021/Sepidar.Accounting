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

namespace Sepidar.Api.Controllers.FormulaBomItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class FormulaBomItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FormulaBomItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddFormulaBomItemCommand command)
        {
            command.Validate();

            var FormulaBomItems = await _unitOfWork.FormulaBomItemRepository.FindAsync(c => c.Id == command.Id);

            if (FormulaBomItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newFormulaBomItem = Mapper.Map(command);
            await _unitOfWork.FormulaBomItemRepository.AddAsync(newFormulaBomItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditFormulaBomItemCommand command)
        {

            command.Validate();

            var FormulaBomItem = await _unitOfWork.FormulaBomItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (FormulaBomItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FormulaBomItem = Mapper.Map(FormulaBomItem, command);
            FormulaBomItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var FormulaBomItem = await _unitOfWork.FormulaBomItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (FormulaBomItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            FormulaBomItem.IsActive = false;
            FormulaBomItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var FormulaBomItems = await _unitOfWork.FormulaBomItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var FormulaBomItemsDto = Mapper.Map(FormulaBomItems);

            return OkResult(CustomMessage.DefaultMessage, FormulaBomItemsDto.ToPagingAndSorting(query), FormulaBomItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var FormulaBomItem = await _unitOfWork.FormulaBomItemRepository.GetByIdAsync(id);

            if (FormulaBomItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var FormulaBomItemDto = Mapper.Map(FormulaBomItem);

            return OkResult( CustomMessage.DefaultMessage , FormulaBomItemDto);

        }
    }
}
