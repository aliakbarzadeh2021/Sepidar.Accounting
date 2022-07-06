using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class POSInvoiceItemRepository : Repository<POSInvoiceItem> , IPOSInvoiceItemRepository
    {
        public POSInvoiceItemRepository(DataContext context) : base(context)
        {
        }
    }
}
