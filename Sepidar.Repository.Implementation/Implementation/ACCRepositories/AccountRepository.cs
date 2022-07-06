using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AccountRepository : Repository<Account> , IAccountRepository
    {
        public AccountRepository(DataContext context) : base(context)
        {
        }
    }
}
