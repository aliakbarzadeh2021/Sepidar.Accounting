using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryPurchaseInvoiceItemRepository : Repository<InventoryPurchaseInvoiceItem> , IInventoryPurchaseInvoiceItemRepository
    {
        public InventoryPurchaseInvoiceItemRepository(DataContext context) : base(context)
        {
        }
    }
}
