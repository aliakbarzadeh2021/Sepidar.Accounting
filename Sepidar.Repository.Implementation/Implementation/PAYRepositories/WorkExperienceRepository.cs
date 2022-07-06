using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class WorkExperienceRepository : Repository<WorkExperience> , IWorkExperienceRepository
    {
        public WorkExperienceRepository(DataContext context) : base(context)
        {
        }
    }
}
