using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MarketingDisketteItemRepository : Repository<MarketingDisketteItem> , IMarketingDisketteItemRepository
    {
        public MarketingDisketteItemRepository(DataContext context) : base(context)
        {
        }
    }
}
