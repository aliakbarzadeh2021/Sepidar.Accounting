using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class LocationRepository : Repository<Location> , ILocationRepository
    {
        public LocationRepository(DataContext context) : base(context)
        {
        }
    }
}
