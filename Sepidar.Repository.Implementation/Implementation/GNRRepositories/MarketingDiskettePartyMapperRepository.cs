using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MarketingDiskettePartyMapperRepository : Repository<MarketingDiskettePartyMapper> , IMarketingDiskettePartyMapperRepository
    {
        public MarketingDiskettePartyMapperRepository(DataContext context) : base(context)
        {
        }
    }
}
