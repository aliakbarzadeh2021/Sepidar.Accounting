using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class QuickBarItemRepository : Repository<QuickBarItem> , IQuickBarItemRepository
    {
        public QuickBarItemRepository(DataContext context) : base(context)
        {
        }
    }
}
