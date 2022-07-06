using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class POSSettlementRepository : Repository<POSSettlement> , IPOSSettlementRepository
    {
        public POSSettlementRepository(DataContext context) : base(context)
        {
        }
    }
}
