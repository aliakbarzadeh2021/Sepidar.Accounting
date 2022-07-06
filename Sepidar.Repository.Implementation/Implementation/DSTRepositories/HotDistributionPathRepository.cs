using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class HotDistributionPathRepository : Repository<HotDistributionPath> , IHotDistributionPathRepository
    {
        public HotDistributionPathRepository(DataContext context) : base(context)
        {
        }
    }
}
