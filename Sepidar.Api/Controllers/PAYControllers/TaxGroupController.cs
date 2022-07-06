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

namespace Sepidar.Api.Controllers.TaxGroupControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TaxGroupController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TaxGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddTaxGroupCommand command)
        {
            command.Validate();

            var TaxGroups = await _unitOfWork.TaxGroupRepository.FindAsync(c => c.Id == command.Id);

            if (TaxGroups.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newTaxGroup = Mapper.Map(command);
            await _unitOfWork.TaxGroupRepository.AddAsync(newTaxGroup);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTaxGroupCommand command)
        {

            command.Validate();

            var TaxGroup = await _unitOfWork.TaxGroupRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (TaxGroup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TaxGroup = Mapper.Map(TaxGroup, command);
            TaxGroup.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var TaxGroup = await _unitOfWork.TaxGroupRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (TaxGroup == null)
                return NotFound(CustomMessage.NotFoundMessage);

            TaxGroup.IsActive = false;
            TaxGroup.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var TaxGroups = await _unitOfWork.TaxGroupRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var TaxGroupsDto = Mapper.Map(TaxGroups);

            return OkResult(CustomMessage.DefaultMessage, TaxGroupsDto.ToPagingAndSorting(query), TaxGroupsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var TaxGroup = await _unitOfWork.TaxGroupRepository.GetByIdAsync(id);

            if (TaxGroup is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var TaxGroupDto = Mapper.Map(TaxGroup);

            return OkResult( CustomMessage.DefaultMessage , TaxGroupDto);

        }
    }
}
