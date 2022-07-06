using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OrderingFailureItemRepository : Repository<OrderingFailureItem> , IOrderingFailureItemRepository
    {
        public OrderingFailureItemRepository(DataContext context) : base(context)
        {
        }
    }
}
