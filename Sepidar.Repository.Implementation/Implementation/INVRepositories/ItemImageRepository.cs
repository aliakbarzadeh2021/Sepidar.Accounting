using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ItemImageRepository : Repository<ItemImage> , IItemImageRepository
    {
        public ItemImageRepository(DataContext context) : base(context)
        {
        }
    }
}
