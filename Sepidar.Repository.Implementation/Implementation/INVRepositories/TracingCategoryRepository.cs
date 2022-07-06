using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TracingCategoryRepository : Repository<TracingCategory> , ITracingCategoryRepository
    {
        public TracingCategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
