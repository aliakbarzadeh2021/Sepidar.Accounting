using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class AccountTypeRepository : Repository<AccountType> , IAccountTypeRepository
    {
        public AccountTypeRepository(DataContext context) : base(context)
        {
        }
    }
}
