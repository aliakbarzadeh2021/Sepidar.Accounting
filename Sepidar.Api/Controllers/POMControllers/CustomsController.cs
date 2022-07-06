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

namespace Sepidar.Api.Controllers.CustomsControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CustomsController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCustomsCommand command)
        {
            command.Validate();

            var Customss = await _unitOfWork.CustomsRepository.FindAsync(c => c.Id == command.Id);

            if (Customss.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCustoms = Mapper.Map(command);
            await _unitOfWork.CustomsRepository.AddAsync(newCustoms);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCustomsCommand command)
        {

            command.Validate();

            var Customs = await _unitOfWork.CustomsRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Customs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Customs = Mapper.Map(Customs, command);
            Customs.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Customs = await _unitOfWork.CustomsRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Customs == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Customs.IsActive = false;
            Customs.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Customss = await _unitOfWork.CustomsRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CustomssDto = Mapper.Map(Customss);

            return OkResult(CustomMessage.DefaultMessage, CustomssDto.ToPagingAndSorting(query), CustomssDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Customs = await _unitOfWork.CustomsRepository.GetByIdAsync(id);

            if (Customs is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CustomsDto = Mapper.Map(Customs);

            return OkResult( CustomMessage.DefaultMessage , CustomsDto);

        }
    }
}
