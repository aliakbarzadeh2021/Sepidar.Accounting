using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PartyRepository : Repository<Party> , IPartyRepository
    {
        public PartyRepository(DataContext context) : base(context)
        {
        }
    }
}
