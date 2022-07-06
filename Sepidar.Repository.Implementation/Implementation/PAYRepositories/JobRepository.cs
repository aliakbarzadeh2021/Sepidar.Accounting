using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class JobRepository : Repository<Job> , IJobRepository
    {
        public JobRepository(DataContext context) : base(context)
        {
        }
    }
}
