using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SchedulingRepository : Repository<Scheduling> , ISchedulingRepository
    {
        public SchedulingRepository(DataContext context) : base(context)
        {
        }
    }
}
