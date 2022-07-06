using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryPurchaseInvoiceRepository : Repository<InventoryPurchaseInvoice> , IInventoryPurchaseInvoiceRepository
    {
        public InventoryPurchaseInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
