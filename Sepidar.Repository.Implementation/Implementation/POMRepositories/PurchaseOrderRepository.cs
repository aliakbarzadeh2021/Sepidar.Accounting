using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PurchaseOrderRepository : Repository<PurchaseOrder> , IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(DataContext context) : base(context)
        {
        }
    }
}
