using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UnuseableRepository : Repository<Unuseable> , IUnuseableRepository
    {
        public UnuseableRepository(DataContext context) : base(context)
        {
        }
    }
}
