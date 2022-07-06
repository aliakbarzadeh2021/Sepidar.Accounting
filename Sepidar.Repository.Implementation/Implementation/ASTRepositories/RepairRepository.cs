using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class RepairRepository : Repository<Repair> , IRepairRepository
    {
        public RepairRepository(DataContext context) : base(context)
        {
        }
    }
}
