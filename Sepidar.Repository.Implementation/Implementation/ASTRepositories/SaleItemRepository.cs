using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SaleItemRepository : Repository<SaleItem> , ISaleItemRepository
    {
        public SaleItemRepository(DataContext context) : base(context)
        {
        }
    }
}
