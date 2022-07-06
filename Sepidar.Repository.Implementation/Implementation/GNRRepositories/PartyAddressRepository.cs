using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PartyAddressRepository : Repository<PartyAddress> , IPartyAddressRepository
    {
        public PartyAddressRepository(DataContext context) : base(context)
        {
        }
    }
}
