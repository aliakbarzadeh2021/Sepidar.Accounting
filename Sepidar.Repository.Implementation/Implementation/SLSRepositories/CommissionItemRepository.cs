using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommissionItemRepository : Repository<CommissionItem> , ICommissionItemRepository
    {
        public CommissionItemRepository(DataContext context) : base(context)
        {
        }
    }
}
