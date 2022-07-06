using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class POSInvoiceRepository : Repository<POSInvoice> , IPOSInvoiceRepository
    {
        public POSInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
