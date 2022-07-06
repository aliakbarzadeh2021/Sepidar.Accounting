using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class HotDistributionItemRepository : Repository<HotDistributionItem> , IHotDistributionItemRepository
    {
        public HotDistributionItemRepository(DataContext context) : base(context)
        {
        }
    }
}
