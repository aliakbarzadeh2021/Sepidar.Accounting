using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class HotDistributionRepository : Repository<HotDistribution> , IHotDistributionRepository
    {
        public HotDistributionRepository(DataContext context) : base(context)
        {
        }
    }
}
