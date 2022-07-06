using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommissionBrokerRepository : Repository<CommissionBroker> , ICommissionBrokerRepository
    {
        public CommissionBrokerRepository(DataContext context) : base(context)
        {
        }
    }
}
