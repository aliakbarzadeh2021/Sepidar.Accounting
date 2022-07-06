using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DebtCollectionListInvoiceRepository : Repository<DebtCollectionListInvoice> , IDebtCollectionListInvoiceRepository
    {
        public DebtCollectionListInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
