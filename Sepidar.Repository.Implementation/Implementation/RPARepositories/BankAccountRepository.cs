using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BankAccountRepository : Repository<BankAccount> , IBankAccountRepository
    {
        public BankAccountRepository(DataContext context) : base(context)
        {
        }
    }
}
