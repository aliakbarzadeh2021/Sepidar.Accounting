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

namespace Sepidar.Api.Controllers.SaleTypeConstraintControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SaleTypeConstraintController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SaleTypeConstraintController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddSaleTypeConstraintCommand command)
        {
            command.Validate();

            var SaleTypeConstraints = await _unitOfWork.SaleTypeConstraintRepository.FindAsync(c => c.Id == command.Id);

            if (SaleTypeConstraints.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newSaleTypeConstraint = Mapper.Map(command);
            await _unitOfWork.SaleTypeConstraintRepository.AddAsync(newSaleTypeConstraint);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditSaleTypeConstraintCommand command)
        {

            command.Validate();

            var SaleTypeConstraint = await _unitOfWork.SaleTypeConstraintRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (SaleTypeConstraint == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SaleTypeConstraint = Mapper.Map(SaleTypeConstraint, command);
            SaleTypeConstraint.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var SaleTypeConstraint = await _unitOfWork.SaleTypeConstraintRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (SaleTypeConstraint == null)
                return NotFound(CustomMessage.NotFoundMessage);

            SaleTypeConstraint.IsActive = false;
            SaleTypeConstraint.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var SaleTypeConstraints = await _unitOfWork.SaleTypeConstraintRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var SaleTypeConstraintsDto = Mapper.Map(SaleTypeConstraints);

            return OkResult(CustomMessage.DefaultMessage, SaleTypeConstraintsDto.ToPagingAndSorting(query), SaleTypeConstraintsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var SaleTypeConstraint = await _unitOfWork.SaleTypeConstraintRepository.GetByIdAsync(id);

            if (SaleTypeConstraint is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var SaleTypeConstraintDto = Mapper.Map(SaleTypeConstraint);

            return OkResult( CustomMessage.DefaultMessage , SaleTypeConstraintDto);

        }
    }
}
