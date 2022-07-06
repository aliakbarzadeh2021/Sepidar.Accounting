using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class StatusItemRepository : Repository<StatusItem> , IStatusItemRepository
    {
        public StatusItemRepository(DataContext context) : base(context)
        {
        }
    }
}
