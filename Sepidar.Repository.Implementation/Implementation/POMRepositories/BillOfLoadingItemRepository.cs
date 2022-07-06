using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class BillOfLoadingItemRepository : Repository<BillOfLoadingItem> , IBillOfLoadingItemRepository
    {
        public BillOfLoadingItemRepository(DataContext context) : base(context)
        {
        }
    }
}
