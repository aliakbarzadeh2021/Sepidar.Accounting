using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SaleTypeConstraintItemRepository : Repository<SaleTypeConstraintItem> , ISaleTypeConstraintItemRepository
    {
        public SaleTypeConstraintItemRepository(DataContext context) : base(context)
        {
        }
    }
}
