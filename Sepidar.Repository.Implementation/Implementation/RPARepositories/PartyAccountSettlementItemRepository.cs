using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PartyAccountSettlementItemRepository : Repository<PartyAccountSettlementItem> , IPartyAccountSettlementItemRepository
    {
        public PartyAccountSettlementItemRepository(DataContext context) : base(context)
        {
        }
    }
}
