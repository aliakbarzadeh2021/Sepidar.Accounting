using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CostPartTransactionRepository : Repository<CostPartTransaction> , ICostPartTransactionRepository
    {
        public CostPartTransactionRepository(DataContext context) : base(context)
        {
        }
    }
}
