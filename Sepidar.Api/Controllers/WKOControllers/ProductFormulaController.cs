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

namespace Sepidar.Api.Controllers.ProductFormulaControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProductFormulaController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductFormulaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductFormulaCommand command)
        {
            command.Validate();

            var ProductFormulas = await _unitOfWork.ProductFormulaRepository.FindAsync(c => c.Id == command.Id);

            if (ProductFormulas.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newProductFormula = Mapper.Map(command);
            await _unitOfWork.ProductFormulaRepository.AddAsync(newProductFormula);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductFormulaCommand command)
        {

            command.Validate();

            var ProductFormula = await _unitOfWork.ProductFormulaRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ProductFormula == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductFormula = Mapper.Map(ProductFormula, command);
            ProductFormula.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ProductFormula = await _unitOfWork.ProductFormulaRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ProductFormula == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ProductFormula.IsActive = false;
            ProductFormula.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ProductFormulas = await _unitOfWork.ProductFormulaRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ProductFormulasDto = Mapper.Map(ProductFormulas);

            return OkResult(CustomMessage.DefaultMessage, ProductFormulasDto.ToPagingAndSorting(query), ProductFormulasDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ProductFormula = await _unitOfWork.ProductFormulaRepository.GetByIdAsync(id);

            if (ProductFormula is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ProductFormulaDto = Mapper.Map(ProductFormula);

            return OkResult( CustomMessage.DefaultMessage , ProductFormulaDto);

        }
    }
}
