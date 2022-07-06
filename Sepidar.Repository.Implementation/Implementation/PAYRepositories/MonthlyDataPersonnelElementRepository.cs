using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class MonthlyDataPersonnelElementRepository : Repository<MonthlyDataPersonnelElement> , IMonthlyDataPersonnelElementRepository
    {
        public MonthlyDataPersonnelElementRepository(DataContext context) : base(context)
        {
        }
    }
}
