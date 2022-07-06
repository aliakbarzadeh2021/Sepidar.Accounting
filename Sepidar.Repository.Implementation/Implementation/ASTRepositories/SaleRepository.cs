using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SaleRepository : Repository<Sale> , ISaleRepository
    {
        public SaleRepository(DataContext context) : base(context)
        {
        }
    }
}
