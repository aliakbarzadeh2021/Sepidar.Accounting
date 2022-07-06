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

namespace Sepidar.Api.Controllers.DebtCollectionListControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DebtCollectionListController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DebtCollectionListController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDebtCollectionListCommand command)
        {
            command.Validate();

            var DebtCollectionLists = await _unitOfWork.DebtCollectionListRepository.FindAsync(c => c.Id == command.Id);

            if (DebtCollectionLists.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDebtCollectionList = Mapper.Map(command);
            await _unitOfWork.DebtCollectionListRepository.AddAsync(newDebtCollectionList);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDebtCollectionListCommand command)
        {

            command.Validate();

            var DebtCollectionList = await _unitOfWork.DebtCollectionListRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DebtCollectionList == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DebtCollectionList = Mapper.Map(DebtCollectionList, command);
            DebtCollectionList.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DebtCollectionList = await _unitOfWork.DebtCollectionListRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DebtCollectionList == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DebtCollectionList.IsActive = false;
            DebtCollectionList.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DebtCollectionLists = await _unitOfWork.DebtCollectionListRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DebtCollectionListsDto = Mapper.Map(DebtCollectionLists);

            return OkResult(CustomMessage.DefaultMessage, DebtCollectionListsDto.ToPagingAndSorting(query), DebtCollectionListsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DebtCollectionList = await _unitOfWork.DebtCollectionListRepository.GetByIdAsync(id);

            if (DebtCollectionList is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DebtCollectionListDto = Mapper.Map(DebtCollectionList);

            return OkResult( CustomMessage.DefaultMessage , DebtCollectionListDto);

        }
    }
}
