using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryBalancingRepository : Repository<InventoryBalancing> , IInventoryBalancingRepository
    {
        public InventoryBalancingRepository(DataContext context) : base(context)
        {
        }
    }
}
