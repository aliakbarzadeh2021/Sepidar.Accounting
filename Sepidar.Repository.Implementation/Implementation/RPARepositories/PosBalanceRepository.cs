using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PosBalanceRepository : Repository<PosBalance> , IPosBalanceRepository
    {
        public PosBalanceRepository(DataContext context) : base(context)
        {
        }
    }
}
