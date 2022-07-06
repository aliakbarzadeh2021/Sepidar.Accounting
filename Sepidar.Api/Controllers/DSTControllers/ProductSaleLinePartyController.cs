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

namespace Sepidar.Api.Controllers.ProductSaleLinePartyControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductSaleLinePartyController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductSaleLinePartyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductSaleLinePartyCommand command)
        {
            command.Validate();

            var ProductSaleLinePartys = await _unitOfWork.ProductSaleLinePartyRepository.FindAsync(c => c.Id == command.Id);

            if (ProductSaleLinePartys.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProductSaleLineParty = Mapper.Map(command);
            await _unitOfWork.ProductSaleLinePartyRepository.AddAsync(newProductSaleLineParty);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductSaleLinePartyCommand command)
        {

            command.Validate();

            var ProductSaleLineParty = await _unitOfWork.ProductSaleLinePartyRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProductSaleLineParty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductSaleLineParty = Mapper.Map(ProductSaleLineParty, command);
            ProductSaleLineParty.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProductSaleLineParty = await _unitOfWork.ProductSaleLinePartyRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProductSaleLineParty == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductSaleLineParty.IsActive = false;
            ProductSaleLineParty.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProductSaleLinePartys = await _unitOfWork.ProductSaleLinePartyRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProductSaleLinePartysDto = Mapper.Map(ProductSaleLinePartys);

            return OkResult(CustomMessage.DefaultMessage, ProductSaleLinePartysDto.ToPagingAndSorting(query), ProductSaleLinePartysDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProductSaleLineParty = await _unitOfWork.ProductSaleLinePartyRepository.GetByIdAsync(id);

            if (ProductSaleLineParty is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProductSaleLinePartyDto = Mapper.Map(ProductSaleLineParty);

            return OkResult( CustomMessage.DefaultMessage , ProductSaleLinePartyDto);

        }
    }
}
