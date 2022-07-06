using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReturnedInvoiceItemRepository : Repository<ReturnedInvoiceItem> , IReturnedInvoiceItemRepository
    {
        public ReturnedInvoiceItemRepository(DataContext context) : base(context)
        {
        }
    }
}
