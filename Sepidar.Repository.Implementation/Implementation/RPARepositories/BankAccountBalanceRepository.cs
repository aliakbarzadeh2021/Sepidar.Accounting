using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BankAccountBalanceRepository : Repository<BankAccountBalance> , IBankAccountBalanceRepository
    {
        public BankAccountBalanceRepository(DataContext context) : base(context)
        {
        }
    }
}
