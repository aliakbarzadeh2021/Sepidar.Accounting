using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TracingRepository : Repository<Tracing> , ITracingRepository
    {
        public TracingRepository(DataContext context) : base(context)
        {
        }
    }
}
