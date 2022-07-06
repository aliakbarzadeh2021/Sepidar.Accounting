using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SalvageItemRepository : Repository<SalvageItem> , ISalvageItemRepository
    {
        public SalvageItemRepository(DataContext context) : base(context)
        {
        }
    }
}
