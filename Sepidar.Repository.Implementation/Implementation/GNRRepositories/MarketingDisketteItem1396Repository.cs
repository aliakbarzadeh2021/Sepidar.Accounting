using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MarketingDisketteItem1396Repository : Repository<MarketingDisketteItem1396> , IMarketingDisketteItem1396Repository
    {
        public MarketingDisketteItem1396Repository(DataContext context) : base(context)
        {
        }
    }
}
