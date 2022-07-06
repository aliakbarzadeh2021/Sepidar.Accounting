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

namespace Sepidar.Api.Controllers.BillOfLoadingControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BillOfLoadingController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BillOfLoadingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddBillOfLoadingCommand command)
        {
            command.Validate();

            var BillOfLoadings = await _unitOfWork.BillOfLoadingRepository.FindAsync(c => c.Id == command.Id);

            if (BillOfLoadings.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newBillOfLoading = Mapper.Map(command);
            await _unitOfWork.BillOfLoadingRepository.AddAsync(newBillOfLoading);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditBillOfLoadingCommand command)
        {

            command.Validate();

            var BillOfLoading = await _unitOfWork.BillOfLoadingRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (BillOfLoading == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BillOfLoading = Mapper.Map(BillOfLoading, command);
            BillOfLoading.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var BillOfLoading = await _unitOfWork.BillOfLoadingRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (BillOfLoading == null)
                return NotFound(CustomMessage.NotFoundMessage);

            BillOfLoading.IsActive = false;
            BillOfLoading.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var BillOfLoadings = await _unitOfWork.BillOfLoadingRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var BillOfLoadingsDto = Mapper.Map(BillOfLoadings);

            return OkResult(CustomMessage.DefaultMessage, BillOfLoadingsDto.ToPagingAndSorting(query), BillOfLoadingsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var BillOfLoading = await _unitOfWork.BillOfLoadingRepository.GetByIdAsync(id);

            if (BillOfLoading is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var BillOfLoadingDto = Mapper.Map(BillOfLoading);

            return OkResult( CustomMessage.DefaultMessage , BillOfLoadingDto);

        }
    }
}
