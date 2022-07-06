using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class CommissionRepository : Repository<Commission> , ICommissionRepository
    {
        public CommissionRepository(DataContext context) : base(context)
        {
        }
    }
}
