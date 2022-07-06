using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PurchaseCostRepository : Repository<PurchaseCost> , IPurchaseCostRepository
    {
        public PurchaseCostRepository(DataContext context) : base(context)
        {
        }
    }
}
