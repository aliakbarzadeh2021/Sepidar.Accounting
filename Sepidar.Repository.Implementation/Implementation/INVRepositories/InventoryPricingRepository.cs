using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryPricingRepository : Repository<InventoryPricing> , IInventoryPricingRepository
    {
        public InventoryPricingRepository(DataContext context) : base(context)
        {
        }
    }
}
