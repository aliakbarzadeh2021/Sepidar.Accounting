using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class POSReturnedInvoiceRepository : Repository<POSReturnedInvoice> , IPOSReturnedInvoiceRepository
    {
        public POSReturnedInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
