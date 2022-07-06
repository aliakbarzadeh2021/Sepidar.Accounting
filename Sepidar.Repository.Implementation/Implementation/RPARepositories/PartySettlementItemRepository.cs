using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PartySettlementItemRepository : Repository<PartySettlementItem> , IPartySettlementItemRepository
    {
        public PartySettlementItemRepository(DataContext context) : base(context)
        {
        }
    }
}
