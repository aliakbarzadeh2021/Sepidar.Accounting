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

namespace Sepidar.Api.Controllers.ChequeBookControllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ChequeBookController : ApiControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChequeBookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddChequeBookCommand command)
        {
            command.Validate();

            var ChequeBooks = await _unitOfWork.ChequeBookRepository.FindAsync(c => c.Id == command.Id);

            if (ChequeBooks.Any())
                return BadRequest(CustomMessage.DuplicateRecordMessage);

            var newChequeBook = Mapper.Map(command);
            await _unitOfWork.ChequeBookRepository.AddAsync(newChequeBook);
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditChequeBookCommand command)
        {

            command.Validate();

            var ChequeBook = await _unitOfWork.ChequeBookRepository.FirstOrDefaultAsync(c => c.Id == command.Id && c.IsActive && !c.IsDeleted);
            if (ChequeBook == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ChequeBook = Mapper.Map(ChequeBook, command);
            ChequeBook.ModifiedBy = UserId;
            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ChequeBook = await _unitOfWork.ChequeBookRepository.FirstOrDefaultAsync(c => c.Id == id && c.IsActive && !c.IsDeleted);
            if (ChequeBook == null)
                return NotFound(CustomMessage.NotFoundMessage);

            ChequeBook.IsActive = false;
            ChequeBook.IsDeleted = true;

            await _unitOfWork.CommitAsync();

            return OkResult(CustomMessage.DefaultMessage);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageQuery query, string search = "")
        {
            var ChequeBooks = await _unitOfWork.ChequeBookRepository.FindAsync(c => c.Id.ToString().Contains(search) && c.IsActive && !c.IsDeleted);

            var ChequeBooksDto = Mapper.Map(ChequeBooks);

            return OkResult(CustomMessage.DefaultMessage, ChequeBooksDto.ToPagingAndSorting(query), ChequeBooksDto.Count());

        }

        [HttpGet("GetDetail/{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            var ChequeBook = await _unitOfWork.ChequeBookRepository.GetByIdAsync(id);

            if (ChequeBook is null)
                return NotFound(CustomMessage.NotFoundMessage);

            var ChequeBookDto = Mapper.Map(ChequeBook);

            return OkResult( CustomMessage.DefaultMessage , ChequeBookDto);

        }
    }
}
