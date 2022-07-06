using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OpeningOperationItemRepository : Repository<OpeningOperationItem> , IOpeningOperationItemRepository
    {
        public OpeningOperationItemRepository(DataContext context) : base(context)
        {
        }
    }
}
