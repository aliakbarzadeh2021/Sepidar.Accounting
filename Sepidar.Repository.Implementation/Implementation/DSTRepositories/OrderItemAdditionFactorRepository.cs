using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OrderItemAdditionFactorRepository : Repository<OrderItemAdditionFactor> , IOrderItemAdditionFactorRepository
    {
        public OrderItemAdditionFactorRepository(DataContext context) : base(context)
        {
        }
    }
}
