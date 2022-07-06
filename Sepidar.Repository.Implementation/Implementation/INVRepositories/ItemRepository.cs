using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ItemRepository : Repository<Item> , IItemRepository
    {
        public ItemRepository(DataContext context) : base(context)
        {
        }
    }
}
