using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ItemPropertyAmountRepository : Repository<ItemPropertyAmount> , IItemPropertyAmountRepository
    {
        public ItemPropertyAmountRepository(DataContext context) : base(context)
        {
        }
    }
}
