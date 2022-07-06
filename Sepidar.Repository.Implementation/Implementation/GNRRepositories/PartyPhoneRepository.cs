using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PartyPhoneRepository : Repository<PartyPhone> , IPartyPhoneRepository
    {
        public PartyPhoneRepository(DataContext context) : base(context)
        {
        }
    }
}
