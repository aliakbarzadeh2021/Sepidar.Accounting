using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SaleTypeRepository : Repository<SaleType> , ISaleTypeRepository
    {
        public SaleTypeRepository(DataContext context) : base(context)
        {
        }
    }
}
