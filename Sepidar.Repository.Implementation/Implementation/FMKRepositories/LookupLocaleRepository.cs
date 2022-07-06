using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class LookupLocaleRepository : Repository<LookupLocale> , ILookupLocaleRepository
    {
        public LookupLocaleRepository(DataContext context) : base(context)
        {
        }
    }
}
