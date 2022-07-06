using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MarketingDiskettItemCategoryMapperRepository : Repository<MarketingDiskettItemCategoryMapper> , IMarketingDiskettItemCategoryMapperRepository
    {
        public MarketingDiskettItemCategoryMapperRepository(DataContext context) : base(context)
        {
        }
    }
}
