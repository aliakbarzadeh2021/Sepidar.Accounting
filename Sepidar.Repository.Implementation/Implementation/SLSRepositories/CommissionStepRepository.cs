using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommissionStepRepository : Repository<CommissionStep> , ICommissionStepRepository
    {
        public CommissionStepRepository(DataContext context) : base(context)
        {
        }
    }
}
