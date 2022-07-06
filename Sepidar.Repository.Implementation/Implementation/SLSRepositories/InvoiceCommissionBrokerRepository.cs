using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InvoiceCommissionBrokerRepository : Repository<InvoiceCommissionBroker> , IInvoiceCommissionBrokerRepository
    {
        public InvoiceCommissionBrokerRepository(DataContext context) : base(context)
        {
        }
    }
}
