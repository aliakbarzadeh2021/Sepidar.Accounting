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

namespace Sepidar.Api.Controllers.DocSpecificationControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DocSpecificationController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DocSpecificationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddDocSpecificationCommand command)
        {
            command.Validate();

            var DocSpecifications = await _unitOfWork.DocSpecificationRepository.FindAsync(c => c.Id == command.Id);

            if (DocSpecifications.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newDocSpecification = Mapper.Map(command);
            await _unitOfWork.DocSpecificationRepository.AddAsync(newDocSpecification);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditDocSpecificationCommand command)
        {

            command.Validate();

            var DocSpecification = await _unitOfWork.DocSpecificationRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (DocSpecification == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DocSpecification = Mapper.Map(DocSpecification, command);
            DocSpecification.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var DocSpecification = await _unitOfWork.DocSpecificationRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (DocSpecification == null)
                return NotFound(CustomMessage.NotFoundMessage);

            DocSpecification.IsActive = false;
            DocSpecification.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var DocSpecifications = await _unitOfWork.DocSpecificationRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var DocSpecificationsDto = Mapper.Map(DocSpecifications);

            return OkResult(CustomMessage.DefaultMessage, DocSpecificationsDto.ToPagingAndSorting(query), DocSpecificationsDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var DocSpecification = await _unitOfWork.DocSpecificationRepository.GetByIdAsync(id);

            if (DocSpecification is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var DocSpecificationDto = Mapper.Map(DocSpecification);

            return OkResult( CustomMessage.DefaultMessage , DocSpecificationDto);

        }
    }
}
