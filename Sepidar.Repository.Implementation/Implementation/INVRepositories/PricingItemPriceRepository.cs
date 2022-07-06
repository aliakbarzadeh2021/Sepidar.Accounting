using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PricingItemPriceRepository : Repository<PricingItemPrice> , IPricingItemPriceRepository
    {
        public PricingItemPriceRepository(DataContext context) : base(context)
        {
        }
    }
}
