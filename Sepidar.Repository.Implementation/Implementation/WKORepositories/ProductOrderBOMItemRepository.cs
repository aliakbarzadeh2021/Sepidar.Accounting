using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProductOrderBOMItemRepository : Repository<ProductOrderBOMItem> , IProductOrderBOMItemRepository
    {
        public ProductOrderBOMItemRepository(DataContext context) : base(context)
        {
        }
    }
}
