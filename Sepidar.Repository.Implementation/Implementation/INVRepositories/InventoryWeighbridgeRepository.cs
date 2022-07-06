using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryWeighbridgeRepository : Repository<InventoryWeighbridge> , IInventoryWeighbridgeRepository
    {
        public InventoryWeighbridgeRepository(DataContext context) : base(context)
        {
        }
    }
}
