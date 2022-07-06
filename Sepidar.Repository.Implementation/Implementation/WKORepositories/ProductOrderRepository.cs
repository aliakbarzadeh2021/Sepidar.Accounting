using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProductOrderRepository : Repository<ProductOrder> , IProductOrderRepository
    {
        public ProductOrderRepository(DataContext context) : base(context)
        {
        }
    }
}
