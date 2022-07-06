using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ItemCategoryRepository : Repository<ItemCategory> , IItemCategoryRepository
    {
        public ItemCategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
