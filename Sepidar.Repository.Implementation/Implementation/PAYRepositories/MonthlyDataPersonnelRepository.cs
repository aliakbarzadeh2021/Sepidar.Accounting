using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MonthlyDataPersonnelRepository : Repository<MonthlyDataPersonnel> , IMonthlyDataPersonnelRepository
    {
        public MonthlyDataPersonnelRepository(DataContext context) : base(context)
        {
        }
    }
}
