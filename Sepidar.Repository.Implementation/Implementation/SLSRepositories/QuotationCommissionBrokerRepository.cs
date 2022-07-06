using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class QuotationCommissionBrokerRepository : Repository<QuotationCommissionBroker> , IQuotationCommissionBrokerRepository
    {
        public QuotationCommissionBrokerRepository(DataContext context) : base(context)
        {
        }
    }
}
