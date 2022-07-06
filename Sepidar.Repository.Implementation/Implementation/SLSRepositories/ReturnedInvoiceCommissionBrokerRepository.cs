using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReturnedInvoiceCommissionBrokerRepository : Repository<ReturnedInvoiceCommissionBroker> , IReturnedInvoiceCommissionBrokerRepository
    {
        public ReturnedInvoiceCommissionBrokerRepository(DataContext context) : base(context)
        {
        }
    }
}
