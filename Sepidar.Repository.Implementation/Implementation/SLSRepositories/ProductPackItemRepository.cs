using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProductPackItemRepository : Repository<ProductPackItem> , IProductPackItemRepository
    {
        public ProductPackItemRepository(DataContext context) : base(context)
        {
        }
    }
}
