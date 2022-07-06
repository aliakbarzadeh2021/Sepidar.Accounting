using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MarketingDiskette1396Repository : Repository<MarketingDiskette1396> , IMarketingDiskette1396Repository
    {
        public MarketingDiskette1396Repository(DataContext context) : base(context)
        {
        }
    }
}
