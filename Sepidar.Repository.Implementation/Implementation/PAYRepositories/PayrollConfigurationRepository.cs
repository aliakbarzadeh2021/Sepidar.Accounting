using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PayrollConfigurationRepository : Repository<PayrollConfiguration> , IPayrollConfigurationRepository
    {
        public PayrollConfigurationRepository(DataContext context) : base(context)
        {
        }
    }
}
