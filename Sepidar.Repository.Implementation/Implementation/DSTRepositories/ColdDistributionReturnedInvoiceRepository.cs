using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ColdDistributionReturnedInvoiceRepository : Repository<ColdDistributionReturnedInvoice> , IColdDistributionReturnedInvoiceRepository
    {
        public ColdDistributionReturnedInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
