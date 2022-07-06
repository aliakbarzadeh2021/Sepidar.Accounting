using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReturnedInvoiceRepository : Repository<ReturnedInvoice> , IReturnedInvoiceRepository
    {
        public ReturnedInvoiceRepository(DataContext context) : base(context)
        {
        }
    }
}
