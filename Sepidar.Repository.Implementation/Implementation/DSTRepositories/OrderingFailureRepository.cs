using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OrderingFailureRepository : Repository<OrderingFailure> , IOrderingFailureRepository
    {
        public OrderingFailureRepository(DataContext context) : base(context)
        {
        }
    }
}
