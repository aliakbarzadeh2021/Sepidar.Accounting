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

namespace Sepidar.Api.Controllers.CommissionControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommissionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommissionCommand command)
        {
            command.Validate();

            var Commissions = await _unitOfWork.CommissionRepository.FindAsync(c => c.Id == command.Id);

            if (Commissions.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newCommission = Mapper.Map(command);
            await _unitOfWork.CommissionRepository.AddAsync(newCommission);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditCommissionCommand command)
        {

            command.Validate();

            var Commission = await _unitOfWork.CommissionRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Commission == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Commission = Mapper.Map(Commission, command);
            Commission.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Commission = await _unitOfWork.CommissionRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Commission == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Commission.IsActive = false;
            Commission.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Commissions = await _unitOfWork.CommissionRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var CommissionsDto = Mapper.Map(Commissions);

            return OkResult(CustomMessage.DefaultMessage, CommissionsDto.ToPagingAndSorting(query), CommissionsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Commission = await _unitOfWork.CommissionRepository.GetByIdAsync(id);

            if (Commission is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var CommissionDto = Mapper.Map(Commission);

            return OkResult( CustomMessage.DefaultMessage , CommissionDto);

        }
    }
}
