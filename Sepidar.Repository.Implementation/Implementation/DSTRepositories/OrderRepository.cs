using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OrderRepository : Repository<Order> , IOrderRepository
    {
        public OrderRepository(DataContext context) : base(context)
        {
        }
    }
}
