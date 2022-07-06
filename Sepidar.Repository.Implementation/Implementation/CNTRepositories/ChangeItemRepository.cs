using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ChangeItemRepository : Repository<ChangeItem> , IChangeItemRepository
    {
        public ChangeItemRepository(DataContext context) : base(context)
        {
        }
    }
}
