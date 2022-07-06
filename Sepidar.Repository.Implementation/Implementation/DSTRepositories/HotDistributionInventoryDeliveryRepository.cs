using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class HotDistributionInventoryDeliveryRepository : Repository<HotDistributionInventoryDelivery> , IHotDistributionInventoryDeliveryRepository
    {
        public HotDistributionInventoryDeliveryRepository(DataContext context) : base(context)
        {
        }
    }
}
