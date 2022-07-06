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

namespace Sepidar.Api.Controllers.ProductPackControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductPackController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductPackController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductPackCommand command)
        {
            command.Validate();

            var ProductPacks = await _unitOfWork.ProductPackRepository.FindAsync(c => c.Id == command.Id);

            if (ProductPacks.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProductPack = Mapper.Map(command);
            await _unitOfWork.ProductPackRepository.AddAsync(newProductPack);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductPackCommand command)
        {

            command.Validate();

            var ProductPack = await _unitOfWork.ProductPackRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProductPack == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductPack = Mapper.Map(ProductPack, command);
            ProductPack.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProductPack = await _unitOfWork.ProductPackRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProductPack == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductPack.IsActive = false;
            ProductPack.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProductPacks = await _unitOfWork.ProductPackRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProductPacksDto = Mapper.Map(ProductPacks);

            return OkResult(CustomMessage.DefaultMessage, ProductPacksDto.ToPagingAndSorting(query), ProductPacksDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProductPack = await _unitOfWork.ProductPackRepository.GetByIdAsync(id);

            if (ProductPack is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProductPackDto = Mapper.Map(ProductPack);

            return OkResult( CustomMessage.DefaultMessage , ProductPackDto);

        }
    }
}
