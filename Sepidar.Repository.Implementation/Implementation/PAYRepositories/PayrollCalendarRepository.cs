using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PayrollCalendarRepository : Repository<PayrollCalendar> , IPayrollCalendarRepository
    {
        public PayrollCalendarRepository(DataContext context) : base(context)
        {
        }
    }
}
