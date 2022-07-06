using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DiscountRepository : Repository<Discount> , IDiscountRepository
    {
        public DiscountRepository(DataContext context) : base(context)
        {
        }
    }
}
