using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PartyRelatedRepository : Repository<PartyRelated> , IPartyRelatedRepository
    {
        public PartyRelatedRepository(DataContext context) : base(context)
        {
        }
    }
}
