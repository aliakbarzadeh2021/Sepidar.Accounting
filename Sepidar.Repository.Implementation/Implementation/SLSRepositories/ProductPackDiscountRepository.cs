using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProductPackDiscountRepository : Repository<ProductPackDiscount> , IProductPackDiscountRepository
    {
        public ProductPackDiscountRepository(DataContext context) : base(context)
        {
        }
    }
}
