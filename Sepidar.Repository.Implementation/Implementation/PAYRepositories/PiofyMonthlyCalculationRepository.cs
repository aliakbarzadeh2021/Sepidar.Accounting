using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class PiofyMonthlyCalculationRepository : Repository<PiofyMonthlyCalculation> , IPiofyMonthlyCalculationRepository
    {
        public PiofyMonthlyCalculationRepository(DataContext context) : base(context)
        {
        }
    }
}
