using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ItemDiscountRepository : Repository<ItemDiscount> , IItemDiscountRepository
    {
        public ItemDiscountRepository(DataContext context) : base(context)
        {
        }
    }
}
