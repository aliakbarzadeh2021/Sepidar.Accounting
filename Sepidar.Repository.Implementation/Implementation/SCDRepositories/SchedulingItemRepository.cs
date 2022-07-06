using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SchedulingItemRepository : Repository<SchedulingItem> , ISchedulingItemRepository
    {
        public SchedulingItemRepository(DataContext context) : base(context)
        {
        }
    }
}
