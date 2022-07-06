using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InvoiceRepository : Repository<Invoice> , IInvoiceRepository
    {
        public InvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
