using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class UseableRepository : Repository<Useable> , IUseableRepository
    {
        public UseableRepository(DataContext context) : base(context)
        {
        }
    }
}
