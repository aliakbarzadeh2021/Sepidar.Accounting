using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UseableItemRepository : Repository<UseableItem> , IUseableItemRepository
    {
        public UseableItemRepository(DataContext context) : base(context)
        {
        }
    }
}
