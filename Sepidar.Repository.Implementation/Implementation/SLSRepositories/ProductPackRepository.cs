using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ProductPackRepository : Repository<ProductPack> , IProductPackRepository
    {
        public ProductPackRepository(DataContext context) : base(context)
        {
        }
    }
}
