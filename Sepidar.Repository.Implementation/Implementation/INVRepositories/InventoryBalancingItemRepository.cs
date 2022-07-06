using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryBalancingItemRepository : Repository<InventoryBalancingItem> , IInventoryBalancingItemRepository
    {
        public InventoryBalancingItemRepository(DataContext context) : base(context)
        {
        }
    }
}
