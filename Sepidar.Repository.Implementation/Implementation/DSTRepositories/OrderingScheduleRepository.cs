using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OrderingScheduleRepository : Repository<OrderingSchedule> , IOrderingScheduleRepository
    {
        public OrderingScheduleRepository(DataContext context) : base(context)
        {
        }
    }
}
