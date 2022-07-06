using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommissionCalculationItemRepository : Repository<CommissionCalculationItem> , ICommissionCalculationItemRepository
    {
        public CommissionCalculationItemRepository(DataContext context) : base(context)
        {
        }
    }
}
