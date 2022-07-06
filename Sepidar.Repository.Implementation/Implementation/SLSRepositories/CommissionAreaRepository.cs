using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommissionAreaRepository : Repository<CommissionArea> , ICommissionAreaRepository
    {
        public CommissionAreaRepository(DataContext context) : base(context)
        {
        }
    }
}
