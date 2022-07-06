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

namespace Sepidar.Api.Controllers.ContractPriceListControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContractPriceListController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContractPriceListController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddContractPriceListCommand command)
        {
            command.Validate();

            var ContractPriceLists = await _unitOfWork.ContractPriceListRepository.FindAsync(c => c.Id == command.Id);

            if (ContractPriceLists.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newContractPriceList = Mapper.Map(command);
            await _unitOfWork.ContractPriceListRepository.AddAsync(newContractPriceList);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditContractPriceListCommand command)
        {

            command.Validate();

            var ContractPriceList = await _unitOfWork.ContractPriceListRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ContractPriceList == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractPriceList = Mapper.Map(ContractPriceList, command);
            ContractPriceList.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ContractPriceList = await _unitOfWork.ContractPriceListRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ContractPriceList == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ContractPriceList.IsActive = false;
            ContractPriceList.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ContractPriceLists = await _unitOfWork.ContractPriceListRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ContractPriceListsDto = Mapper.Map(ContractPriceLists);

            return OkResult(CustomMessage.DefaultMessage, ContractPriceListsDto.ToPagingAndSorting(query), ContractPriceListsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ContractPriceList = await _unitOfWork.ContractPriceListRepository.GetByIdAsync(id);

            if (ContractPriceList is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ContractPriceListDto = Mapper.Map(ContractPriceList);

            return OkResult( CustomMessage.DefaultMessage , ContractPriceListDto);

        }
    }
}
