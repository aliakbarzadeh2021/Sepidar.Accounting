using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PayrollConfigurationElementRepository : Repository<PayrollConfigurationElement> , IPayrollConfigurationElementRepository
    {
        public PayrollConfigurationElementRepository(DataContext context) : base(context)
        {
        }
    }
}
