using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ShredItemRepository : Repository<ShredItem> , IShredItemRepository
    {
        public ShredItemRepository(DataContext context) : base(context)
        {
        }
    }
}
