using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryReceiptRepository : Repository<InventoryReceipt> , IInventoryReceiptRepository
    {
        public InventoryReceiptRepository(DataContext context) : base(context)
        {
        }
    }
}
