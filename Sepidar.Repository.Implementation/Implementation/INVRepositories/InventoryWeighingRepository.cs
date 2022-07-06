using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class InventoryWeighingRepository : Repository<InventoryWeighing> , IInventoryWeighingRepository
    {
        public InventoryWeighingRepository(DataContext context) : base(context)
        {
        }
    }
}
