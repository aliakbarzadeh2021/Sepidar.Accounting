using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CashRepository : Repository<Cash> , ICashRepository
    {
        public CashRepository(DataContext context) : base(context)
        {
        }
    }
}
