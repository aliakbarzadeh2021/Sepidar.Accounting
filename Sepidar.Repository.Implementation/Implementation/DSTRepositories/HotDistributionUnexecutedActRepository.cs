using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class HotDistributionUnexecutedActRepository : Repository<HotDistributionUnexecutedAct> , IHotDistributionUnexecutedActRepository
    {
        public HotDistributionUnexecutedActRepository(DataContext context) : base(context)
        {
        }
    }
}
