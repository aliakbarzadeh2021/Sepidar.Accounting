using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class RepairItemRepository : Repository<RepairItem> , IRepairItemRepository
    {
        public RepairItemRepository(DataContext context) : base(context)
        {
        }
    }
}
