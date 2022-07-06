using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PurchaseInvoiceRepository : Repository<PurchaseInvoice> , IPurchaseInvoiceRepository
    {
        public PurchaseInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
