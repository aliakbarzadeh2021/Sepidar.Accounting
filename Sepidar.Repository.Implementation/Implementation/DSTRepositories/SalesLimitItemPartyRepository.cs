using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SalesLimitItemPartyRepository : Repository<SalesLimitItemParty> , ISalesLimitItemPartyRepository
    {
        public SalesLimitItemPartyRepository(DataContext context) : base(context)
        {
        }
    }
}
