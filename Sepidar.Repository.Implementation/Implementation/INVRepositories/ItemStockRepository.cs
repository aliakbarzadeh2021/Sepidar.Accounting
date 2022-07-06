using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ItemStockRepository : Repository<ItemStock> , IItemStockRepository
    {
        public ItemStockRepository(DataContext context) : base(context)
        {
        }
    }
}
