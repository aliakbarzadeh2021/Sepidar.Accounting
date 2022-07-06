using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class WorkshopRepository : Repository<Workshop> , IWorkshopRepository
    {
        public WorkshopRepository(DataContext context) : base(context)
        {
        }
    }
}
