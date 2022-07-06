using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class LookupRepository : Repository<Lookup> , ILookupRepository
    {
        public LookupRepository(DataContext context) : base(context)
        {
        }
    }
}
