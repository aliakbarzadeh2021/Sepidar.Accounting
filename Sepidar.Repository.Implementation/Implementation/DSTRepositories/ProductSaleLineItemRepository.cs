using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProductSaleLineItemRepository : Repository<ProductSaleLineItem> , IProductSaleLineItemRepository
    {
        public ProductSaleLineItemRepository(DataContext context) : base(context)
        {
        }
    }
}
