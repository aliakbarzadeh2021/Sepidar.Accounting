using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PurchaseCostItemRepository : Repository<PurchaseCostItem> , IPurchaseCostItemRepository
    {
        public PurchaseCostItemRepository(DataContext context) : base(context)
        {
        }
    }
}
