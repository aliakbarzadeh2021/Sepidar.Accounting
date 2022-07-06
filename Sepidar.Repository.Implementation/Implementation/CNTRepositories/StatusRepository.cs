using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class StatusRepository : Repository<Status> , IStatusRepository
    {
        public StatusRepository(DataContext context) : base(context)
        {
        }
    }
}
