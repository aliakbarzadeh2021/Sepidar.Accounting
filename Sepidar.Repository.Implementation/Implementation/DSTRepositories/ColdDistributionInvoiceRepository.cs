using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ColdDistributionInvoiceRepository : Repository<ColdDistributionInvoice> , IColdDistributionInvoiceRepository
    {
        public ColdDistributionInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
