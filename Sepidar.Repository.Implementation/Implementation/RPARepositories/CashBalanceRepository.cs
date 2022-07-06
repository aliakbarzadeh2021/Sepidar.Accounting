using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CashBalanceRepository : Repository<CashBalance> , ICashBalanceRepository
    {
        public CashBalanceRepository(DataContext context) : base(context)
        {
        }
    }
}
