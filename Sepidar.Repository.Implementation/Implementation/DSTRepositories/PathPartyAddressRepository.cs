using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PathPartyAddressRepository : Repository<PathPartyAddress> , IPathPartyAddressRepository
    {
        public PathPartyAddressRepository(DataContext context) : base(context)
        {
        }
    }
}
