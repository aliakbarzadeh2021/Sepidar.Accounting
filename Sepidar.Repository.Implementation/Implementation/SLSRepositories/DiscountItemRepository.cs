using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DiscountItemRepository : Repository<DiscountItem> , IDiscountItemRepository
    {
        public DiscountItemRepository(DataContext context) : base(context)
        {
        }
    }
}
