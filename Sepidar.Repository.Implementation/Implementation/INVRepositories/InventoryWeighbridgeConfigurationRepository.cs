using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryWeighbridgeConfigurationRepository : Repository<InventoryWeighbridgeConfiguration> , IInventoryWeighbridgeConfigurationRepository
    {
        public InventoryWeighbridgeConfigurationRepository(DataContext context) : base(context)
        {
        }
    }
}
