using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReturnOrderItemRepository : Repository<ReturnOrderItem> , IReturnOrderItemRepository
    {
        public ReturnOrderItemRepository(DataContext context) : base(context)
        {
        }
    }
}
