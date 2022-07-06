using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SalesLimitRepository : Repository<SalesLimit> , ISalesLimitRepository
    {
        public SalesLimitRepository(DataContext context) : base(context)
        {
        }
    }
}
