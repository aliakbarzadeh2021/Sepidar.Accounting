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

namespace Sepidar.Api.Controllers.ReconciliationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReconciliationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReconciliationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddReconciliationCommand command)
        {
            command.Validate();

            var Reconciliations = await _unitOfWork.ReconciliationRepository.FindAsync(c => c.Id == command.Id);

            if (Reconciliations.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newReconciliation = Mapper.Map(command);
            await _unitOfWork.ReconciliationRepository.AddAsync(newReconciliation);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditReconciliationCommand command)
        {

            command.Validate();

            var Reconciliation = await _unitOfWork.ReconciliationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Reconciliation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Reconciliation = Mapper.Map(Reconciliation, command);
            Reconciliation.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Reconciliation = await _unitOfWork.ReconciliationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Reconciliation == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Reconciliation.IsActive = false;
            Reconciliation.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Reconciliations = await _unitOfWork.ReconciliationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ReconciliationsDto = Mapper.Map(Reconciliations);

            return OkResult(CustomMessage.DefaultMessage, ReconciliationsDto.ToPagingAndSorting(query), ReconciliationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Reconciliation = await _unitOfWork.ReconciliationRepository.GetByIdAsync(id);

            if (Reconciliation is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ReconciliationDto = Mapper.Map(Reconciliation);

            return OkResult( CustomMessage.DefaultMessage , ReconciliationDto);

        }
    }
}
