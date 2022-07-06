using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MarketingDisketteRepository : Repository<MarketingDiskette> , IMarketingDisketteRepository
    {
        public MarketingDisketteRepository(DataContext context) : base(context)
        {
        }
    }
}
