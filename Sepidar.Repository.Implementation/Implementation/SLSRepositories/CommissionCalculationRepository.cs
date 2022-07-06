using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommissionCalculationRepository : Repository<CommissionCalculation> , ICommissionCalculationRepository
    {
        public CommissionCalculationRepository(DataContext context) : base(context)
        {
        }
    }
}
