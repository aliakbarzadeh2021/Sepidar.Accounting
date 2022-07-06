using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class WorksiteRepository : Repository<Worksite> , IWorksiteRepository
    {
        public WorksiteRepository(DataContext context) : base(context)
        {
        }
    }
}
