using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class POSSettlementItemRepository : Repository<POSSettlementItem> , IPOSSettlementItemRepository
    {
        public POSSettlementItemRepository(DataContext context) : base(context)
        {
        }
    }
}
