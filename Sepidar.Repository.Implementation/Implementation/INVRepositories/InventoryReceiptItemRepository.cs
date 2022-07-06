using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryReceiptItemRepository : Repository<InventoryReceiptItem> , IInventoryReceiptItemRepository
    {
        public InventoryReceiptItemRepository(DataContext context) : base(context)
        {
        }
    }
}
