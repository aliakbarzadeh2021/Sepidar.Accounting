using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class POSReturnedInvoiceItemRepository : Repository<POSReturnedInvoiceItem> , IPOSReturnedInvoiceItemRepository
    {
        public POSReturnedInvoiceItemRepository(DataContext context) : base(context)
        {
        }
    }
}
