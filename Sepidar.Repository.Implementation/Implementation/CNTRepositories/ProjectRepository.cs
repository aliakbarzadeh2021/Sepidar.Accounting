using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProjectRepository : Repository<Project> , IProjectRepository
    {
        public ProjectRepository(DataContext context) : base(context)
        {
        }
    }
}
