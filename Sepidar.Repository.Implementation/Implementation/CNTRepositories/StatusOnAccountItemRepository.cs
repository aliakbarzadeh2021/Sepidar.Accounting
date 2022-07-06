using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class StatusOnAccountItemRepository : Repository<StatusOnAccountItem> , IStatusOnAccountItemRepository
    {
        public StatusOnAccountItemRepository(DataContext context) : base(context)
        {
        }
    }
}
