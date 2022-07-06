using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SalesLimitItemRepository : Repository<SalesLimitItem> , ISalesLimitItemRepository
    {
        public SalesLimitItemRepository(DataContext context) : base(context)
        {
        }
    }
}
