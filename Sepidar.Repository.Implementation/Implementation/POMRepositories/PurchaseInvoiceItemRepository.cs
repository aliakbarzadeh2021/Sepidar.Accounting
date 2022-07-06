using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PurchaseInvoiceItemRepository : Repository<PurchaseInvoiceItem> , IPurchaseInvoiceItemRepository
    {
        public PurchaseInvoiceItemRepository(DataContext context) : base(context)
        {
        }
    }
}
