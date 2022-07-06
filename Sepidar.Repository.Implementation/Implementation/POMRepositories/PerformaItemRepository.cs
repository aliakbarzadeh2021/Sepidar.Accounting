using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PerformaItemRepository : Repository<PerformaItem> , IPerformaItemRepository
    {
        public PerformaItemRepository(DataContext context) : base(context)
        {
        }
    }
}
