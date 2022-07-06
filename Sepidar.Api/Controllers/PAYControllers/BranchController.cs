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

namespace Sepidar.Api.Controllers.BranchControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BranchController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BranchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBranchCommand command)
        {
            command.Validate();

            var Branchs = await _unitOfWork.BranchRepository.FindAsync(c => c.Id == command.Id);

            if (Branchs.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBranch = Mapper.Map(command);
            await _unitOfWork.BranchRepository.AddAsync(newBranch);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBranchCommand command)
        {

            command.Validate();

            var Branch = await _unitOfWork.BranchRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (Branch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Branch = Mapper.Map(Branch, command);
            Branch.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var Branch = await _unitOfWork.BranchRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (Branch == null)
                return NotFound(CustomMessage.NotFoundMessage);

            Branch.IsActive = false;
            Branch.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var Branchs = await _unitOfWork.BranchRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BranchsDto = Mapper.Map(Branchs);

            return OkResult(CustomMessage.DefaultMessage, BranchsDto.ToPagingAndSorting(query), BranchsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var Branch = await _unitOfWork.BranchRepository.GetByIdAsync(id);

            if (Branch is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BranchDto = Mapper.Map(Branch);

            return OkResult( CustomMessage.DefaultMessage , BranchDto);

        }
    }
}
