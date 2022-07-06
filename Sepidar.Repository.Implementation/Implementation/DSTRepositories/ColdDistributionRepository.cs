using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ColdDistributionRepository : Repository<ColdDistribution> , IColdDistributionRepository
    {
        public ColdDistributionRepository(DataContext context) : base(context)
        {
        }
    }
}
