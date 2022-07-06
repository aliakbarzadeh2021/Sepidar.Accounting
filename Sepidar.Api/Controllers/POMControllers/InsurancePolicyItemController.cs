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

namespace Sepidar.Api.Controllers.InsurancePolicyItemControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InsurancePolicyItemController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public InsurancePolicyItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddInsurancePolicyItemCommand command)
        {
            command.Validate();

            var InsurancePolicyItems = await _unitOfWork.InsurancePolicyItemRepository.FindAsync(c => c.Id == command.Id);

            if (InsurancePolicyItems.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newInsurancePolicyItem = Mapper.Map(command);
            await _unitOfWork.InsurancePolicyItemRepository.AddAsync(newInsurancePolicyItem);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditInsurancePolicyItemCommand command)
        {

            command.Validate();

            var InsurancePolicyItem = await _unitOfWork.InsurancePolicyItemRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (InsurancePolicyItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InsurancePolicyItem = Mapper.Map(InsurancePolicyItem, command);
            InsurancePolicyItem.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var InsurancePolicyItem = await _unitOfWork.InsurancePolicyItemRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (InsurancePolicyItem == null)
                return NotFound(CustomMessage.NotFoundMessage);

            InsurancePolicyItem.IsActive = false;
            InsurancePolicyItem.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var InsurancePolicyItems = await _unitOfWork.InsurancePolicyItemRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var InsurancePolicyItemsDto = Mapper.Map(InsurancePolicyItems);

            return OkResult(CustomMessage.DefaultMessage, InsurancePolicyItemsDto.ToPagingAndSorting(query), InsurancePolicyItemsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var InsurancePolicyItem = await _unitOfWork.InsurancePolicyItemRepository.GetByIdAsync(id);

            if (InsurancePolicyItem is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var InsurancePolicyItemDto = Mapper.Map(InsurancePolicyItem);

            return OkResult( CustomMessage.DefaultMessage , InsurancePolicyItemDto);

        }
    }
}
