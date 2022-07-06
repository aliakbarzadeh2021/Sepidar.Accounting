using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UnuseableItemRepository : Repository<UnuseableItem> , IUnuseableItemRepository
    {
        public UnuseableItemRepository(DataContext context) : base(context)
        {
        }
    }
}
