using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryPricingVoucherItemRepository : Repository<InventoryPricingVoucherItem> , IInventoryPricingVoucherItemRepository
    {
        public InventoryPricingVoucherItemRepository(DataContext context) : base(context)
        {
        }
    }
}
