using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SettlementItemRepository : Repository<SettlementItem> , ISettlementItemRepository
    {
        public SettlementItemRepository(DataContext context) : base(context)
        {
        }
    }
}
