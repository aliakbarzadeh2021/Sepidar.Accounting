using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PriceNoteItemRepository : Repository<PriceNoteItem> , IPriceNoteItemRepository
    {
        public PriceNoteItemRepository(DataContext context) : base(context)
        {
        }
    }
}
