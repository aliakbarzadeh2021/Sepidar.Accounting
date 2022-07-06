using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PurchaseOtherCostItemRepository : Repository<PurchaseOtherCostItem> , IPurchaseOtherCostItemRepository
    {
        public PurchaseOtherCostItemRepository(DataContext context) : base(context)
        {
        }
    }
}
