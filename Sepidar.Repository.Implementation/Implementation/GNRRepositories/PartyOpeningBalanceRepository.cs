using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PartyOpeningBalanceRepository : Repository<PartyOpeningBalance> , IPartyOpeningBalanceRepository
    {
        public PartyOpeningBalanceRepository(DataContext context) : base(context)
        {
        }
    }
}
