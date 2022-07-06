using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InvoiceBrokerRepository : Repository<InvoiceBroker> , IInvoiceBrokerRepository
    {
        public InvoiceBrokerRepository(DataContext context) : base(context)
        {
        }
    }
}
