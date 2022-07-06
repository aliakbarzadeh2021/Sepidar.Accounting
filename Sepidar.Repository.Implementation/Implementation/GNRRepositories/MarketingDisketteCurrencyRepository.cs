using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MarketingDisketteCurrencyRepository : Repository<MarketingDisketteCurrency> , IMarketingDisketteCurrencyRepository
    {
        public MarketingDisketteCurrencyRepository(DataContext context) : base(context)
        {
        }
    }
}
