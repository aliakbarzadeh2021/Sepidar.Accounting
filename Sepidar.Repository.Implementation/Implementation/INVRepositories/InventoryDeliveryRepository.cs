using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryDeliveryRepository : Repository<InventoryDelivery> , IInventoryDeliveryRepository
    {
        public InventoryDeliveryRepository(DataContext context) : base(context)
        {
        }
    }
}
