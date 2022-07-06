using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class TruckRepository : Repository<Truck> , ITruckRepository
    {
        public TruckRepository(DataContext context) : base(context)
        {
        }
    }
}
