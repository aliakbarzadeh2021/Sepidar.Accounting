using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PriceNoteRepository : Repository<PriceNote> , IPriceNoteRepository
    {
        public PriceNoteRepository(DataContext context) : base(context)
        {
        }
    }
}
