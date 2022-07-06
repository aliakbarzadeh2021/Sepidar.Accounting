using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MonthlyDataRepository : Repository<MonthlyData> , IMonthlyDataRepository
    {
        public MonthlyDataRepository(DataContext context) : base(context)
        {
        }
    }
}
