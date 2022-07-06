using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryDeliveryItemRepository : Repository<InventoryDeliveryItem> , IInventoryDeliveryItemRepository
    {
        public InventoryDeliveryItemRepository(DataContext context) : base(context)
        {
        }
    }
}
