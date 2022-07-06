using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DepreciationItemRepository : Repository<DepreciationItem> , IDepreciationItemRepository
    {
        public DepreciationItemRepository(DataContext context) : base(context)
        {
        }
    }
}
