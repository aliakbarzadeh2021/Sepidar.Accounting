using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CashierRepository : Repository<Cashier> , ICashierRepository
    {
        public CashierRepository(DataContext context) : base(context)
        {
        }
    }
}
