using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProductSaleLinePartyRepository : Repository<ProductSaleLineParty> , IProductSaleLinePartyRepository
    {
        public ProductSaleLinePartyRepository(DataContext context) : base(context)
        {
        }
    }
}
