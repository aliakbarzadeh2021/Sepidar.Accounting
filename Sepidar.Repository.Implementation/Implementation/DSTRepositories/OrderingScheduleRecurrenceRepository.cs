using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OrderingScheduleRecurrenceRepository : Repository<OrderingScheduleRecurrence> , IOrderingScheduleRecurrenceRepository
    {
        public OrderingScheduleRecurrenceRepository(DataContext context) : base(context)
        {
        }
    }
}
