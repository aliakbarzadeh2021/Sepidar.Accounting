using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class OrderingScheduleRelatedActivitiesRepository : Repository<OrderingScheduleRelatedActivities> , IOrderingScheduleRelatedActivitiesRepository
    {
        public OrderingScheduleRelatedActivitiesRepository(DataContext context) : base(context)
        {
        }
    }
}
