using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class DailyHourMinuteRepository : Repository<DailyHourMinute> , IDailyHourMinuteRepository
    {
        public DailyHourMinuteRepository(DataContext context) : base(context)
        {
        }
    }
}
