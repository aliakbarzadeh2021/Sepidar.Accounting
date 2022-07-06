using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PosSettlementRepository : Repository<PosSettlement> , IPosSettlementRepository
    {
        public PosSettlementRepository(DataContext context) : base(context)
        {
        }
    }
}
