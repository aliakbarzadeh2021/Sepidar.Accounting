using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InvoiceItemRepository : Repository<InvoiceItem> , IInvoiceItemRepository
    {
        public InvoiceItemRepository(DataContext context) : base(context)
        {
        }
    }
}
