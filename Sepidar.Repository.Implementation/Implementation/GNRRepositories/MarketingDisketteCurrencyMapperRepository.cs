using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MarketingDisketteCurrencyMapperRepository : Repository<MarketingDisketteCurrencyMapper> , IMarketingDisketteCurrencyMapperRepository
    {
        public MarketingDisketteCurrencyMapperRepository(DataContext context) : base(context)
        {
        }
    }
}
