using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProductSaleLineRepository : Repository<ProductSaleLine> , IProductSaleLineRepository
    {
        public ProductSaleLineRepository(DataContext context) : base(context)
        {
        }
    }
}
