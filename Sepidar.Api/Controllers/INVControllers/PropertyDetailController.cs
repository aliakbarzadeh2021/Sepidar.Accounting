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

namespace Sepidar.Api.Controllers.PropertyDetailControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyDetailController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PropertyDetailController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddPropertyDetailCommand command)
        {
            command.Validate();

            var PropertyDetails = await _unitOfWork.PropertyDetailRepository.FindAsync(c => c.Id == command.Id);

            if (PropertyDetails.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newPropertyDetail = Mapper.Map(command);
            await _unitOfWork.PropertyDetailRepository.AddAsync(newPropertyDetail);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditPropertyDetailCommand command)
        {

            command.Validate();

            var PropertyDetail = await _unitOfWork.PropertyDetailRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (PropertyDetail == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PropertyDetail = Mapper.Map(PropertyDetail, command);
            PropertyDetail.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var PropertyDetail = await _unitOfWork.PropertyDetailRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (PropertyDetail == null)
                return NotFound(CustomMessage.NotFoundMessage);

            PropertyDetail.IsActive = false;
            PropertyDetail.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var PropertyDetails = await _unitOfWork.PropertyDetailRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var PropertyDetailsDto = Mapper.Map(PropertyDetails);

            return OkResult(CustomMessage.DefaultMessage, PropertyDetailsDto.ToPagingAndSorting(query), PropertyDetailsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var PropertyDetail = await _unitOfWork.PropertyDetailRepository.GetByIdAsync(id);

            if (PropertyDetail is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var PropertyDetailDto = Mapper.Map(PropertyDetail);

            return OkResult( CustomMessage.DefaultMessage , PropertyDetailDto);

        }
    }
}
