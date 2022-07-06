using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BankRepository : Repository<Bank> , IBankRepository
    {
        public BankRepository(DataContext context) : base(context)
        {
        }
    }
}
