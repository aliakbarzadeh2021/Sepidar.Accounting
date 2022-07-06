using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CustomsClearanceItemRepository : Repository<CustomsClearanceItem> , ICustomsClearanceItemRepository
    {
        public CustomsClearanceItemRepository(DataContext context) : base(context)
        {
        }
    }
}
