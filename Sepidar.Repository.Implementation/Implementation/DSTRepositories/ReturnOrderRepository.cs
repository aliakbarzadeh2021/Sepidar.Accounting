using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class ReturnOrderRepository : Repository<ReturnOrder> , IReturnOrderRepository
    {
        public ReturnOrderRepository(DataContext context) : base(context)
        {
        }
    }
}
