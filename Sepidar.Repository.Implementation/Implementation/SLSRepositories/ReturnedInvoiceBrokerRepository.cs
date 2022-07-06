using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReturnedInvoiceBrokerRepository : Repository<ReturnedInvoiceBroker> , IReturnedInvoiceBrokerRepository
    {
        public ReturnedInvoiceBrokerRepository(DataContext context) : base(context)
        {
        }
    }
}
