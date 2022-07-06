using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PurchaseOrderItemRepository : Repository<PurchaseOrderItem> , IPurchaseOrderItemRepository
    {
        public PurchaseOrderItemRepository(DataContext context) : base(context)
        {
        }
    }
}
