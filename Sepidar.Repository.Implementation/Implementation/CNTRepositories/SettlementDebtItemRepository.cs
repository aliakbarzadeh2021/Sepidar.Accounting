using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SettlementDebtItemRepository : Repository<SettlementDebtItem> , ISettlementDebtItemRepository
    {
        public SettlementDebtItemRepository(DataContext context) : base(context)
        {
        }
    }
}
