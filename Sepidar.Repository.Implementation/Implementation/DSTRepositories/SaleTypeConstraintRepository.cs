using Sepidar.Domain.Entities;
using Sepidar.Repository.Repositories;

namespace Sepidar.Repository.Implementation.Implementation
{
    public class SaleTypeConstraintRepository : Repository<SaleTypeConstraint> , ISaleTypeConstraintRepository
    {
        public SaleTypeConstraintRepository(DataContext context) : base(context)
        {
        }
    }
}
