using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ItemStockSummaryRepository : Repository<ItemStockSummary> , IItemStockSummaryRepository
    {
        public ItemStockSummaryRepository(DataContext context) : base(context)
        {
        }
    }
}
