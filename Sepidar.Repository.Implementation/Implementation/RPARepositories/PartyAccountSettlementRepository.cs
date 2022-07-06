using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PartyAccountSettlementRepository : Repository<PartyAccountSettlement> , IPartyAccountSettlementRepository
    {
        public PartyAccountSettlementRepository(DataContext context) : base(context)
        {
        }
    }
}
